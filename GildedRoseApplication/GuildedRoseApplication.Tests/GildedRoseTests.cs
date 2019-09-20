using GildedRoseApplication;
using System.Collections.Generic;
using Xunit;

namespace GuildedRoseApplication.Tests
{
    public sealed class GildedRoseTest
    {
        #region Dextery Vest tests

        [Fact]
        public void DexterityVestWhenGildedRoseThenSellInAndQualityDecreasedByOne()
        {
            IList<Item> Items = new List<Item> { CreateDexteryVest(10, 20) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(9, Items[0].SellIn);
            Assert.Equal(19, Items[0].Quality);
        }

        [Fact]
        public void DexterityVestWhenGildedRoseAndNoSellInThenQualityDecreasedByTwo()
        {
            IList<Item> Items = new List<Item> { CreateDexteryVest(0, 20) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(18, Items[0].Quality);
        }

        [Fact]
        public void DexterityVestWhenGildedRoseAndNoSellInAndNoQualityThenQualityIsNotDecreased()
        {
            IList<Item> Items = new List<Item> { CreateDexteryVest(0, 0) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }

        #endregion

        #region Aged Brie

        [Fact]
        public void AgedBrieWhenGildedRoseThenSellInIsDecreasedByOneAndQualityIncreasedByOne()
        {
            IList<Item> Items = new List<Item> { CreateAgedBrie(2, 0) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(1, Items[0].SellIn);
            Assert.Equal(1, Items[0].Quality);
        }

        [Fact]
        public void AgedBrieWhenGildedRoseAndNoSellInThenQualityIncreasedByTwo()
        {
            IList<Item> Items = new List<Item> { CreateAgedBrie(0, 2) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(4, Items[0].Quality);
        }

        [Fact]
        public void AgedBrieWhenGildedRoseAndMaxQualityThenQualityIsNotIncreased()
        {
            IList<Item> Items = new List<Item> { CreateAgedBrie(0, 50) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(50, Items[0].Quality);
        }

        #endregion

        #region Elixir of the Mongoose

        [Fact]
        public void ElixirMongooseWhenGildedRoseThenSellInAndQualityAreDecreasedByOne()
        {
            IList<Item> Items = new List<Item> { CreateElixirOfMongoose(5, 7) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(4, Items[0].SellIn);
            Assert.Equal(6, Items[0].Quality);
        }

        [Fact]
        public void ElixirMongooseWhenGildedRoseAndNoSellInThenQualityIsDecreasedByTwo()
        {
            IList<Item> Items = new List<Item> { CreateElixirOfMongoose(0, 7) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(5, Items[0].Quality);
        }

        [Fact]
        public void ElixirMongooseWhenGildedRoseAndNoSellInAndNoQualityThenQualityIsNotDecreased()
        {
            IList<Item> Items = new List<Item> { CreateElixirOfMongoose(0, 0) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }

        #endregion

        #region Sulfuras, Hand of Ragnaros

        [Fact]
        public void SulfurasWhenGildedRoseThenSellInAndQualityRemainTheSame()
        {
            IList<Item> Items = new List<Item> { CreateSulfurasHandOfRagnaros(0, 80) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].SellIn);
            Assert.Equal(80, Items[0].Quality);
        }

        [Fact]
        public void SulfurasWhenGildedRoseAndNoSellInThenSellInAndQualityRemainTheSame()
        {
            IList<Item> Items = new List<Item> { CreateSulfurasHandOfRagnaros(-1, 80) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(80, Items[0].Quality);
        }

        #endregion

        #region Backstage passes

        [Fact]
        public void BackstagePassesWhenGildedRoseAndSellInThenSellInIsDecreasedByOneAndQualityIncreasedByOne()
        {
            IList<Item> Items = new List<Item> { CreateBackstagePasses(15, 20) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(14, Items[0].SellIn);
            Assert.Equal(21, Items[0].Quality);
        }

        [Fact]
        public void BackstagePassesWhenGildedRoseAndSellInLessOrEqualThanTenThenSellInIsDecreasedByOneAndQualityIncreasedByTwo()
        {
            IList<Item> Items = new List<Item> { CreateBackstagePasses(10, 20) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(9, Items[0].SellIn);
            Assert.Equal(22, Items[0].Quality);
        }

        [Fact]
        public void BackstagePassesWhenGildedRoseAndSellInLessOrEqualThanFiveThenSellInIsDecreasedByOneAndQualityIncreasedByThree()
        {
            IList<Item> Items = new List<Item> { CreateBackstagePasses(5, 20) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(4, Items[0].SellIn);
            Assert.Equal(23, Items[0].Quality);
        }

        [Fact]
        public void BackstagePassesWhenGildedRoseAndSellInAndMaxQualityThenSellInIsDecreasedByOneAndQualityIsNotIncreased()
        {
            IList<Item> Items = new List<Item> { CreateBackstagePasses(15, 50) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(14, Items[0].SellIn);
            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        public void BackstagePassesWhenGildedRoseAndNoSellThenQualityIsZero()
        {
            IList<Item> Items = new List<Item> { CreateBackstagePasses(0, 50) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }

        #endregion

        #region Conjured Mana Cake

        //[Fact]
        //public void ConjuredManaCakeWhenGildedRoseThenSellInIsDecreasedByOneAndQualityIsDecreasedByTwo()
        //{
        //    IList<Item> Items = new List<Item> { CreateConjuredManaCake(10, 20) };
        //    GildedRose app = new GildedRose(Items);
        //    app.UpdateQuality();
        //    Assert.Equal(9, Items[0].SellIn);
        //    Assert.Equal(18, Items[0].Quality);
        //}

        //[Fact]
        //public void ConjuredManaCakeWhenGildedRoseAndNoSellInThenQualityDecreasedByFour()
        //{
        //    IList<Item> Items = new List<Item> { CreateConjuredManaCake(0, 20) };
        //    GildedRose app = new GildedRose(Items);
        //    app.UpdateQuality();
        //    Assert.Equal(-1, Items[0].SellIn);
        //    Assert.Equal(16, Items[0].Quality);
        //}

        //[Fact]
        //public void ConjuredManaCakeWhenGildedRoseAndNoSellInAndNoQualityThenQualityIsNotDecreased()
        //{
        //    IList<Item> Items = new List<Item> { CreateConjuredManaCake(0, 0) };
        //    GildedRose app = new GildedRose(Items);
        //    app.UpdateQuality();
        //    Assert.Equal(-1, Items[0].SellIn);
        //    Assert.Equal(0, Items[0].Quality);
        //}

        #endregion

        #region Item creators

        private static Item CreateDexteryVest(int sellIn, int quality)
        {
            return CreateItem("+5 Dexterity Vest", sellIn, quality);
        }

        private static Item CreateAgedBrie(int sellIn, int quality)
        {
            return CreateItem("Aged Brie", sellIn, quality);
        }

        private static Item CreateElixirOfMongoose(int sellIn, int quality)
        {
            return CreateItem("Elixir of the Mongoose", sellIn, quality);
        }

        private static Item CreateSulfurasHandOfRagnaros(int sellIn, int quality)
        {
            return CreateItem("Sulfuras, Hand of Ragnaros", sellIn, quality);
        }

        private static Item CreateBackstagePasses(int sellIn, int quality)
        {
            return CreateItem("Backstage passes to a TAFKAL80ETC concert", sellIn, quality);
        }

        private static Item CreateConjuredManaCake(int sellIn, int quality)
        {
            return CreateItem("Conjured Mana Cake", sellIn, quality);
        }

        private static Item CreateItem(string name, int sellIn, int quality)
        {
            return new Item { Name = name, SellIn = sellIn, Quality = quality };
        }

        #endregion
    }
}
