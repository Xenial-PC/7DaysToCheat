using System;
using System.Windows.Forms;
using C7D2C.Classes;

namespace C7D2C.Menus
{
    public partial class BlockEditorMenu : Form
    {
        public BlockEditorMenu()
        {
            InitializeComponent();
            TopMost = true;
            ShowInTaskbar = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        { 
            Hide();
        }

        private void HeaderLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Overlay.ReleaseCapture();
            Overlay.SendMessage(Handle, Overlay.WmNclButtonDown, Overlay.HtCaption, 0);
        }

        private void HeadPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Overlay.ReleaseCapture();
            Overlay.SendMessage(Handle, Overlay.WmNclButtonDown, Overlay.HtCaption, 0);
        }

        private void ResetBlockButton_Click(object sender, EventArgs e)
        {
            var blockListSelectedItem = BlockListBox.SelectedIndex;
            var blockItemClass = ItemClass.GetItem((string) BlockListBox.Items[blockListSelectedItem]);
            BlockModifier.ResetBlockToOriginalValues(blockItemClass.ItemClass.GetBlock());

            var blockValues = GetAllItems.BlockList[blockListSelectedItem];

            BlockHealthValue.Value = blockValues.MaxDamage;
            BlockHealthUpgradeValue.Value = blockValues.MaxDamagePlusDowngrades;

            BlockCraftTimeValue.Value = (int)blockValues.CraftComponentTime;
            BlockCraftComponentExpValue.Value = (int)blockValues.CraftComponentExp;
        }

        private void BlockEditorMenu_Load(object sender, EventArgs e)
        {
            GetAllItems.GetAllBlocks();
            foreach (var blockValues in GetAllItems.BlockList)
                BlockListBox.Items.Add(blockValues.Block);
        }

        private void GetCurrentHeldBlockButton_Click(object sender, EventArgs e)
        {
            if (!Main.LocalPlayerEntity.inventory.holdingItem.IsBlock()) return;
            var heldItem = Main.LocalPlayerEntity.inventory.holdingItem.GetBlock();

            BlockListBox.SelectedIndex = BlockListBox.Items.IndexOf(heldItem.GetBlockName());

            BlockHealthValue.Value = heldItem.MaxDamage;
            BlockHealthUpgradeValue.Value = heldItem.MaxDamagePlusDowngrades;

            BlockCraftTimeValue.Value = (int)heldItem.CraftComponentTime;
            BlockCraftComponentExpValue.Value = (int)heldItem.CraftComponentExp;
        }

        private void UpdateBlockButton_Click(object sender, EventArgs e)
        {
            var blockListSelectedItem = BlockListBox.SelectedIndex;
            var blockItemClass = ItemClass.GetItem((string)BlockListBox.Items[blockListSelectedItem]);
            BlockModifier.UpdateBlockValues(blockItemClass.ItemClass.GetBlock(), (int)BlockHealthValue.Value, (int)BlockHealthUpgradeValue.Value, (int)BlockCraftTimeValue.Value, (int)BlockCraftComponentExpValue.Value);
        }

        private void BlockListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var blockListSelectedItem = BlockListBox.SelectedIndex;
            var blockValues = GetAllItems.BlockList[blockListSelectedItem].Block;
            var item = ItemClass.GetItem(blockValues).ItemClass.GetBlock();

            BlockHealthValue.Value = item.MaxDamage;
            BlockHealthUpgradeValue.Value = item.MaxDamagePlusDowngrades;

            BlockCraftTimeValue.Value = (int)item.CraftComponentTime;
            BlockCraftComponentExpValue.Value = (int)item.CraftComponentExp;
        }
    }
}