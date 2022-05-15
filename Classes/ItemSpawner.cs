using System;
using UnityEngine;
using System.Windows.Forms;

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
            var itemName = Overlay.GetInstance().ItemNameTextBox.Text;
            if (string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show(@"ItemName TexBox Is Empty");
                return;
            }
            var newItem = ItemClass.GetItem(itemName, false);

            var itemQuality = Overlay.GetInstance().ItemQualityTextBox.Text;
            if (string.IsNullOrEmpty(itemQuality)) itemQuality = newItem.Quality.ToString();
            var itemQualityConverted = Convert.ToInt32(itemQuality);

            var itemAmount = Overlay.GetInstance().ItemAmountTextBox.Text;
            var itemAmountConverted = 1;
            if (string.IsNullOrEmpty(itemAmount)) itemAmountConverted = 1;
            else itemAmountConverted = Convert.ToInt32(Overlay.GetInstance().ItemAmountTextBox.Text);

            var itemStack = new ItemStack(new ItemValue(newItem.type, itemQualityConverted, itemQualityConverted, true, null, 1f), itemAmountConverted);

            if (!Overlay.GetInstance().SpawnItemsAboveHeadCheckBox.Checked)
            {
                GameManager.Instance.World.GetPrimaryPlayer().bag.AddItem(itemStack);
                return;
            }
            GameManager.Instance.World.gameManager.ItemDropServer(itemStack, new Vector3(0, 2, 0), new Vector3(0, 0), Main.LocalPlayerEntity.entityId, 60F, true);
            //GameManager.Instance.adminTools.AddAdmin();
        }
    }
}