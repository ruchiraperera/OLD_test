//example - when we want to add method to sealed class we can use extension method.

to create a extension method you have to create public static class.


if you want can have all the extension under system namespace


namspace system{

	public static class StringExtensions{
	
		public static subNetString(this String _s, string name){
		
		
		}
	}
}

so system namspace is define all the places by default
so this extension method will also be available within th assembly