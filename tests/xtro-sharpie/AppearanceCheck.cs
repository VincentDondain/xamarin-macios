//
// The rule reports
//
// !missing-appearance-attribute!
//		when a managed member is missing its [Appearance] attribute
//

using System;
using System.Collections.Generic;

using Mono.Cecil;

using Clang.Ast;

namespace Extrospection {

	public class AppearanceCheck : BaseVisitor {

		static Dictionary<string,MethodDefinition> methods = new Dictionary<string,MethodDefinition> ();

		static MethodDefinition GetMethod (ObjCMethodDecl decl)
		{
			methods.TryGetValue (decl.GetName (), out var md);
			return md;
		}

		public override void VisitManagedMethod (MethodDefinition method)
		{
			var key = method.GetName ();
			if (key == null)
				return;

			// we still have one case to fix with duplicate selectors :|
			if (!methods.ContainsKey (key))
				methods.Add (key, method);
		}

		public override void VisitObjCCategoryDecl (ObjCCategoryDecl decl, VisitKind visitKind)
		{
			if (visitKind != VisitKind.Enter)
				return;
			foreach (var d in decl.Methods)
				Visit (d);
		}

		public override void VisitObjCMethodDecl (ObjCMethodDecl decl, VisitKind visitKind)
		{
			if (visitKind != VisitKind.Enter)
				return;
			Visit (decl);
		}

		void Visit (ObjCMethodDecl decl)
		{
			// don't process methods (or types) that are unavailable for the current platform
			if (!decl.IsAvailable () || !(decl.DeclContext as Decl).IsAvailable ())
				return;

			var method = GetMethod (decl);
			if (method == null)
				return;

			var framework = Helpers.GetFramework (decl);
			if (framework == null)
				return;

			if (!method.Appearance ()) {
				Log.On (framework).Add ($"!missing-appearance-attribute! {method.GetName ()} is missing an [Appearance] attribute");
			}
		}
	}
}
