using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace C7D2C.Classes
{
    class FreeCraft : MonoBehaviour
    {
        [NotNull] private static readonly List<Recipe> RecipesCached = new List<Recipe>();
        [NotNull] private static readonly List<List<ItemStack>> RecipeItems = new List<List<ItemStack>>();
        [NotNull] private static readonly List<float> RecipeTimes = new List<float>();

        public void Start()
        {
            RecipesCached.Clear();
            RecipesCached.AddRange(CraftingManager.GetAllRecipes());
            Overlay.GetInstance().EnableFreeCraftingCheckBox.Click += EnableFreeCraftingCheckBox_Clicked;
        }

        private void EnableFreeCraftingCheckBox_Clicked(object sender, EventArgs e)
        {
            if (Overlay.GetInstance().EnableFreeCraftingCheckBox.Checked)
            {
                EnableFreeCraft();
                return;
            }
            DisableFreeCraft();
        }

        public void EnableFreeCraft()
        {
            foreach (var recipe in RecipesCached)
            {
                RecipeItems.Add(recipe.ingredients);
                RecipeTimes.Add(recipe.craftingTime);

                var customRecipe = recipe;
                customRecipe.ingredients = new List<ItemStack>();
                customRecipe.craftingTime = 0f;

                CraftingManager.AddRecipe(customRecipe);
            }
        }

        public void DisableFreeCraft()
        {
            for (var i = 0; i < RecipesCached.Count; i++)
            {
                var recipe = RecipesCached[i];
                var customRecipe = recipe;
                customRecipe.ingredients = RecipeItems[i];
                customRecipe.craftingTime = RecipeTimes[i];

                CraftingManager.AddRecipe(customRecipe);
            }
        }
    }
}