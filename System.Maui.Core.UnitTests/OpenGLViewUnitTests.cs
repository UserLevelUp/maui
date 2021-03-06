using NUnit.Framework;

namespace System.Maui.Core.UnitTests
{
	[TestFixture]
	public class OpenGLViewUnitTests : BaseTestFixture
	{
		[Test]
		public void Display ()
		{
			var view = new OpenGLView ();
			bool displayed = false;

			view.DisplayRequested += (s, o) => displayed = true;

			view.Display ();
			Assert.True (displayed);
		}
	}
}
