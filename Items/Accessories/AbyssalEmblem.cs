using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using TaoMod;

namespace TaoMod.Items.Accessories
{
	public class AbyssalEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("20% decreased insanity gain");
		}

		public override void SetDefaults() {
			item.width = 32;
			item.height = 52;
			item.accessory = true;
			item.rare = 4;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			TaoPlayer modPlayer = TaoPlayer.ModPlayer(player);
		}
	}
}