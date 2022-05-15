using System;
using UnityEngine;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _7DaysToCheat.Classes
{
    internal class ItemSpawner : MonoBehaviour
    {
        public void Start()
        {
            Overlay.GetInstance().SpawnItemButton.Click += SpawnItemButton_Click;
        }

        private void SpawnItemButton_Click(object sender, EventArgs e)
        {
            SpawnItem();
        }

        public static void SpawnItem()
        {
            var itemName = Overlay.GetInstance().ItemNameComboBox.Text;
            if (string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show(@"ItemName TexBox Is Empty");
                return;
            }
            var newItem = ItemClass.GetItem(itemName);

            var itemQuality = Overlay.GetInstance().ItemQualityNumberBox.Value;
            var itemQualityConverted = Convert.ToInt32(itemQuality);

            newItem.Quality = itemQualityConverted;

            var itemAmount = Overlay.GetInstance().ItemAmountTextBox.Text;
            var itemAmountConverted = string.IsNullOrEmpty(itemAmount) ? 1 : Convert.ToInt32(Overlay.GetInstance().ItemAmountTextBox.Text);
            var itemStack = new ItemStack(newItem, itemAmountConverted);

            if (!Overlay.GetInstance().SpawnItemsAboveHeadCheckBox.Checked)
            {
                GameManager.Instance.World.GetPrimaryPlayer().bag.AddItem(itemStack);
                return;
            }
            GameManager.Instance.World.gameManager.ItemDropServer(itemStack, new Vector3(0, 2, 0), new Vector3(0, 0), Main.LocalPlayerEntity.entityId, 60F, true);
        }
    }
}