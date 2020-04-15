using Terraria.ID;
using Terraria.ModLoader;

namespace TaoMod.Items.Materials
{
	public class EssenceofYin : ModItem
	{
		public override void SetStaticDefaults() {

            DisplayName.SetDefault("Essence of Yin");
			Tooltip.SetDefault("'The very essence of darkness'\nThe Abyssal Mage might be interested in this");
	        ItemID.Sets.ItemIconPulse[item.type] = true;
		}
		public override void SetDefaults() {
			item.width = 16;
			item.height = 22;
			item.maxStack = 99;
			item.value = 100;
			item.rare = 11;
			item.alpha = 55;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}
    }
}

