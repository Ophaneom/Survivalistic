using System.Collections.Generic;

namespace Survivalistic.Framework.Databases
{
    public class Foods
    {
        public static Dictionary<string, string> GetFoodDatabase()
        {
			Dictionary<string, string> holder = new Dictionary<string, string>();

			holder.Add("Wild Horseradish", "0/0");
			holder.Add("Daffodil", "0/0");
			holder.Add("Leek", "0/0");
			holder.Add("Dandelion", "100/100");
			holder.Add("Parsnip", "0/0");
			holder.Add("Cave Carrot", "0/0");
			holder.Add("Coconut", "0/0");
			holder.Add("Cactus Fruit", "0/0");
			holder.Add("Sap", "0/0");
			holder.Add("Anchovy", "10/0");
			holder.Add("Tuna", "0/0");
			holder.Add("Sardine", "0/0");
			holder.Add("Bream", "0/0");
			holder.Add("Largemouth Bass", "0/0");
			holder.Add("Smallmouth Bass", "0/0");
			holder.Add("Rainbow Trout", "0/0");
			holder.Add("Salmon", "0/0");
			holder.Add("Walleye", "0/0");
			holder.Add("Perch", "0/0");
			holder.Add("Carp", "0/0");
			holder.Add("Catfish", "0/0");
			holder.Add("Pike", "0/0");
			holder.Add("Sunfish", "0/0");
			holder.Add("Red Mullet", "0/0");
			holder.Add("Herring", "10/2");
			holder.Add("Eel", "0/0");
			holder.Add("Octopus", "0/0");
			holder.Add("Red Snapper", "0/0");
			holder.Add("Squid", "0/0");
			holder.Add("Seaweed", "0/0");
			holder.Add("Green Algae", "0/0");
			holder.Add("Sea Cucumber", "0/0");
			holder.Add("Super Cucumber", "0/0");
			holder.Add("Ghostfish", "0/0");
			holder.Add("White Algae", "0/0");
			holder.Add("Stonefish", "0/0");
			holder.Add("Crimsonfish", "0/0");
			holder.Add("Angler", "0/0");
			holder.Add("Ice Pip", "0/0");
			holder.Add("Lava Eel", "0/0");
			holder.Add("Legend", "0/0");
			holder.Add("Sandfish", "0/0");
			holder.Add("Scorpion Carp", "0/0");
			holder.Add("Joja Cola", "0/20");
			holder.Add("Egg", "0/0");
			holder.Add("Large Egg", "0/0");
			holder.Add("Milk", "0/0");
			holder.Add("Large Milk", "0/0");
			holder.Add("Green Bean", "0/0");
			holder.Add("Fiddlehead Risotto", "0/0");
			holder.Add("Cauliflower", "0/0");
			holder.Add("Potato", "0/0");
			holder.Add("Fried Egg", "0/0");
			holder.Add("Omelet", "0/0");
			holder.Add("Salad", "0/0");
			holder.Add("Cheese Cauliflower", "0/0");
			holder.Add("Baked Fish", "0/0");
			holder.Add("Parsnip Soup", "0/0");
			holder.Add("Vegetable Medley", "0/0");
			holder.Add("Complete Breakfast", "0/0");
			holder.Add("Fried Calamari", "0/0");
			holder.Add("Strange Bun", "0/0");
			holder.Add("Lucky Lunch", "0/0");
			holder.Add("Fried Mushroom", "0/0");
			holder.Add("Pizza", "0/0");
			holder.Add("Bean Hotpot", "0/0");
			holder.Add("Glazed Yams", "0/0");
			holder.Add("Carp Surprise", "0/0");
			holder.Add("Hashbrowns", "0/0");
			holder.Add("Pancakes", "0/0");
			holder.Add("Salmon Dinner", "0/0");
			holder.Add("Fish Taco", "0/0");
			holder.Add("Crispy Bass", "0/0");
			holder.Add("Pepper Poppers", "0/0");
			holder.Add("Bread", "0/0");
			holder.Add("Tom Kha Soup", "0/0");
			holder.Add("Trout Soup", "0/0");
			holder.Add("Chocolate Cake", "0/0");
			holder.Add("Pink Cake", "0/0");
			holder.Add("Rhubarb Pie", "0/0");
			holder.Add("Cookie", "0/0");
			holder.Add("Spaghetti", "0/0");
			holder.Add("Fried Eel", "0/0");
			holder.Add("Spicy Eel", "0/0");
			holder.Add("Sashimi", "0/0");
			holder.Add("Maki Roll", "0/0");
			holder.Add("Tortilla", "0/0");
			holder.Add("Red Plate", "0/0");
			holder.Add("Eggplant Parmesan", "0/0");
			holder.Add("Rice Pudding", "0/0");
			holder.Add("Ice Cream", "0/0");
			holder.Add("Blueberry Tart", "0/0");
			holder.Add("Autumn's Bounty", "0/0");
			holder.Add("Pumpkin Soup", "0/0");
			holder.Add("Super Meal", "0/0");
			holder.Add("Cranberry Sauce", "0/0");
			holder.Add("Stuffing", "0/0");
			holder.Add("Farmer's Lunch", "0/0");
			holder.Add("Survival Burger", "0/0");
			holder.Add("Dish O' The Sea", "0/0");
			holder.Add("Miner's Treat", "0/0");
			holder.Add("Roots Platter", "0/0");
			holder.Add("Sugar", "0/0");
			holder.Add("Wheat Flour", "0/0");
			holder.Add("Oil", "0/0");
			holder.Add("Garlic", "0/0");
			holder.Add("Kale", "0/0");
			holder.Add("Rhubarb", "0/0");
			holder.Add("Melon", "0/0");
			holder.Add("Tomato", "0/0");
			holder.Add("Morel", "0/0");
			holder.Add("Blueberry", "0/0");
			holder.Add("Fiddlehead Fern", "0/0");
			holder.Add("Hot Pepper", "0/0");
			holder.Add("Wheat", "0/0");
			holder.Add("Radish", "0/0");
			holder.Add("Red Cabbage", "0/0");
			holder.Add("Starfruit", "0/0");
			holder.Add("Corn", "0/0");
			holder.Add("Eggplant", "0/0");
			holder.Add("Artichoke", "0/0");
			holder.Add("Pumpkin", "0/0");
			holder.Add("Bok Choy", "0/0");
			holder.Add("Yam", "0/0");
			holder.Add("Chanterelle", "0/0");
			holder.Add("Cranberries", "0/0");
			holder.Add("Holly", "0/0");
			holder.Add("Beet", "0/0");
			holder.Add("Cherry Bomb", "0/0");
			holder.Add("Bomb", "0/0");
			holder.Add("Mega Bomb", "0/0");
			holder.Add("Stone", "0/0");
			holder.Add("Salmonberry", "0/0");
			holder.Add("Amaranth", "0/0"); //////////////////////
			holder.Add("Pale Ale", "0/0");
			holder.Add("Hops", "0/0");
			holder.Add("Void Egg", "0/0");
			holder.Add("Mayonnaise", "0/0");
			holder.Add("Duck Mayonnaise", "0/0");
			holder.Add("Void Mayonnaise", "0/0");
			holder.Add("Acorn", "0/0"); /////////////////////
			holder.Add("Maple Seed", "0/0"); /////////////////////
			holder.Add("Pine Cone", "0/0"); /////////////////////
			holder.Add("Clay", "0/0"); /////////////////////
			holder.Add("Pickles", "0/0"); /////////////////////
			holder.Add("Jelly", "0/0"); /////////////////////
			holder.Add("Beer", "0/0");
			holder.Add("Wine", "0/0");
			holder.Add("Juice", "0/0");
			holder.Add("Golden Pumpkin", "0/0"); /////////////////////
			holder.Add("Coral", "0/0"); /////////////////////
			holder.Add("Coffee", "0/0");
			holder.Add("Spice Berry", "0/0");
			holder.Add("Sea Urchin", "0/0"); /////////////////////
			holder.Add("Grape", "0/0");
			holder.Add("Spring Onion", "0/0");
			holder.Add("Strawberry", "0/0");
			holder.Add("Sweet Pea", "0/0");
			holder.Add("Field Snack", "0/0");
			holder.Add("Common Mushroom", "0/0");
			holder.Add("Wild Plum", "0/0");
			holder.Add("Hazelnut", "0/0"); /////////////////////
			holder.Add("Blackberry", "0/0");
			holder.Add("Winter Root", "0/0"); /////////////////////
			holder.Add("Crystal Fruit", "0/0");
			holder.Add("Snow Yam", "0/0");
			holder.Add("Sweet Gem Berry", "0/0");
			holder.Add("Crocus", "0/0");
			holder.Add("Vinegar", "0/0"); /////////////////////
			holder.Add("Red Mushroom", "0/0"); /////////////////////
			holder.Add("Sunflower", "0/0"); /////////////////////
			holder.Add("Purple Mushroom", "0/0");
			holder.Add("Rice", "0/0");
			holder.Add("Cheese", "0/0");
			holder.Add("Goat Cheese", "0/0");
			holder.Add("Truffle", "0/0");
			holder.Add("Truffle Oil", "0/0"); /////////////////////
			holder.Add("Coffee Bean", "0/0");
			holder.Add("Stardrop", "0/0"); /////////////////////
			holder.Add("Goat Milk", "0/0");
			holder.Add("Duck Egg", "0/0");
			holder.Add("Ancient Fruit", "0/0"); /////////////////////
			holder.Add("Algae Soup", "0/0");
			holder.Add("Pale Broth", "0/0");
			holder.Add("Mead", "0/0");
			holder.Add("Tulip", "0/0");
			holder.Add("Summer Spangle", "0/0");
			holder.Add("Fairy Rose", "0/0");
			holder.Add("Blue Jazz", "0/0");
			holder.Add("Poppy", "0/0");
			holder.Add("Plum Pudding", "0/0");
			holder.Add("Artichoke Dip", "0/0");
			holder.Add("Stir Fry", "0/0");
			holder.Add("Roasted Hazelnuts", "0/0");
			holder.Add("Pumpkin Pie", "0/0");
			holder.Add("Radish Salad", "0/0");
			holder.Add("Fruit Salad", "0/0");
			holder.Add("Blackberry Cobbler", "0/0");
			holder.Add("Cranberry Candy", "0/0");
			holder.Add("Apple", "0/0");
			holder.Add("Bruschetta", "0/0");
			holder.Add("Coleslaw", "0/0");
			holder.Add("Poppyseed Muffin", "0/0");
			holder.Add("Apricot", "0/0");
			holder.Add("Orange", "0/0");
			holder.Add("Peach", "0/0");
			holder.Add("Pomegranate", "0/0");
			holder.Add("Cherry", "0/0");
			holder.Add("Bug Meat", "0/0");
			holder.Add("Sturgeon", "0/0");
			holder.Add("Tiger Trout", "0/0");
			holder.Add("Bullhead", "0/0");
			holder.Add("Tilapia", "0/0");
			holder.Add("Chub", "0/0");
			holder.Add("Dorado", "0/0");
			holder.Add("Albacore", "0/0");
			holder.Add("Shad", "0/0");
			holder.Add("Lingcod", "0/0");
			holder.Add("Halibut", "0/0");
			holder.Add("Lobster", "0/0");
			holder.Add("Crayfish", "0/0");
			holder.Add("Crab", "0/0"); ////////////////////////
			holder.Add("Cockle", "0/0"); ////////////////////////
			holder.Add("Mussel", "0/0"); ////////////////////////
			holder.Add("Shrimp", "0/0");
			holder.Add("Snail", "0/0"); ////////////////////////
			holder.Add("Periwinkle", "0/0"); ////////////////////////
			holder.Add("Oyster", "0/0"); ////////////////////////
			holder.Add("Maple Syrup", "0/0");
			holder.Add("Oak Resin", "0/0");
			holder.Add("Pine Tar", "0/0");
			holder.Add("Chowder", "0/0");
			holder.Add("Lobster Bisque", "0/0");
			holder.Add("Fish Stew", "0/0");
			holder.Add("Escargot", "0/0");
			holder.Add("Maple Bar", "0/0");
			holder.Add("Crab Cakes", "0/0");
			holder.Add("Woodskip", "0/0");
			holder.Add("Life Elixir", "0/0"); ////////////////////////
			holder.Add("Void Salmon", "0/0");
			holder.Add("Slimejack", "0/0");

			if (ModEntry.instance.Helper.ModRegistry.IsLoaded("blueberry.LoveOfCooking"))
            {
				holder.Add("blueberry.cac.admiralpie", "1/1");
				holder.Add("blueberry.cac.applepie", "100/100");
				holder.Add("blueberry.cac.bakedpotato", "1/1");
				holder.Add("blueberry.cac.breakfast", "1/1");
				holder.Add("blueberry.cac.burger", "1/1");
				holder.Add("blueberry.cac.burntfood", "1/1");
				holder.Add("blueberry.cac.burrito", "1/1");
				holder.Add("blueberry.cac.cabbage", "1/1");
				holder.Add("blueberry.cac.cabbage Juice", "1/1");
				holder.Add("blueberry.cac.cabbage_seeds", "1/1");
				holder.Add("blueberry.cac.cabbagepot", "1/1");
				holder.Add("blueberry.cac.cake", "1/1");
				holder.Add("blueberry.cac.cake_half", "1/1");
				holder.Add("blueberry.cac.carrot", "1/1");
				holder.Add("blueberry.cac.carrot Juice", "1/1");
				holder.Add("blueberry.cac.carrot_seeds", "1/1");
				holder.Add("blueberry.cac.chocolate", "1/1");
				holder.Add("blueberry.cac.chocolatecake_half", "1/1");
				holder.Add("blueberry.cac.cider", "1/1");
				holder.Add("blueberry.cac.cookbook", "1/1");
				holder.Add("blueberry.cac.curry", "1/1");
				holder.Add("blueberry.cac.dwarfstew", "1/1");
				holder.Add("blueberry.cac.eggsando", "1/1");
				holder.Add("blueberry.cac.eggsando_half", "1/1");
				holder.Add("blueberry.cac.fritters", "1/1");
				holder.Add("blueberry.cac.gardenpie", "1/1");
				holder.Add("blueberry.cac.hotcocoa", "1/1");
				holder.Add("blueberry.cac.hunters", "1/1");
				holder.Add("blueberry.cac.kebab", "1/1");
				holder.Add("blueberry.cac.loadedpotato", "1/1");
				holder.Add("blueberry.cac.lobster", "1/1");
				holder.Add("blueberry.cac.mornay", "1/1");
				holder.Add("blueberry.cac.nettles", "1/1");
				holder.Add("blueberry.cac.nettletea", "1/1");
				holder.Add("blueberry.cac.oceanplatter", "1/1");
				holder.Add("blueberry.cac.onion", "1/1");
				holder.Add("blueberry.cac.onion Juice", "1/1");
				holder.Add("blueberry.cac.onion_seeds", "1/1");
				holder.Add("blueberry.cac.onionsoup", "1/1");
				holder.Add("blueberry.cac.pinkcake_half", "1/1");
				holder.Add("blueberry.cac.pizza_half", "1/1");
				holder.Add("blueberry.cac.porridge", "1/1");
				holder.Add("blueberry.cac.redberry", "1/1");
				holder.Add("blueberry.cac.redberry Jelly", "1/1");
				holder.Add("blueberry.cac.redberry Wine", "1/1");
				holder.Add("blueberry.cac.redberry_seeds", "1/1");
				holder.Add("blueberry.cac.redberrypie", "1/1");
				holder.Add("blueberry.cac.roast", "1/1");
				holder.Add("blueberry.cac.saladsando", "1/1");
				holder.Add("blueberry.cac.saladsando_half", "1/1");
				holder.Add("blueberry.cac.seafoodsando", "1/1");
				holder.Add("blueberry.cac.seafoodsando_half", "1/1");
				holder.Add("blueberry.cac.skewers", "1/1");
				holder.Add("blueberry.cac.stew", "1/1");
				holder.Add("blueberry.cac.stuffedpotato", "1/1");
				holder.Add("blueberry.cac.sugarcane Juice", "1/1");
				holder.Add("blueberry.cac.tropicalsalad", "1/1");
				holder.Add("blueberry.cac.unagi", "1/1");
				holder.Add("blueberry.cac.waffles", "1/1");
				holder.Add("blueberry.cac.watermelon", "1/1");
				holder.Add("blueberry.cac.watermelon Jelly", "1/1");
				holder.Add("blueberry.cac.watermelon Wine", "1/1");
				holder.Add("blueberry.cac.watermelon_half", "1/1");
				holder.Add("blueberry.cac.watermelon_seeds", "1/1");
				holder.Add("Pickled blueberry.cac.cabbage", "1/1");
				holder.Add("Pickled blueberry.cac.carrot", "1/1");
				holder.Add("Pickled blueberry.cac.onion", "1/1");
				holder.Add("Pickled blueberry.cac.sugarcane", "1/1");
			}

			return holder;
		}
    }
}
