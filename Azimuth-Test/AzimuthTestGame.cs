using Azimuth;
using Azimuth.UI;

using Raylib_cs;

using System.Numerics;

namespace Azimuth_Test
{
	public class AzimuthTestGame : Game
	{
		private ImageWidget image;
		private Button button;
		public override void Load()
		{
			image = new ImageWidget(Vector2.Zero, new Vector2(400, 400), "dwayne");
			button = new Button(new Vector2(image.position.X + image.size.X, image.position.Y + image.size.Y / 2 ), new Vector2(150, 75), Button.RenderSettings.normal);
			UIManager.Add(button);
			UIManager.Add(image);
		}

		

		public override void Unload()
		{
			
		}
	}
}