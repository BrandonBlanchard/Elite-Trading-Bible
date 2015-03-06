using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.TradingBible.Models;

namespace Assets.TradingBible.Data
{
    public class FakeDb
    {
        public IEnumerable<CommodityDbModel> Commodities { get; private set; }

        public IEnumerable<CultureDbModel> Cultures { get; private set; }

        public FakeDb()
        {
            // Source: http://i.imgur.com/QsxScn1.png
            Commodities = PopulateCommodities();
            Cultures = PopulateCultures();
        }

        private IEnumerable<CultureDbModel> PopulateCultures()
        {
            return new List<CultureDbModel>()
            {
                // Pesticides
                new CultureDbModel( cultureType.highTech, EconomicRelationship.sells, commodityType.pesticides ),
                new CultureDbModel( cultureType.agriculture, EconomicRelationship.buys, commodityType.pesticides ),
                
                // Agricultural Medicines
                new CultureDbModel( cultureType.highTech, EconomicRelationship.sells, commodityType.agriculturalMedicines ),
                new CultureDbModel( cultureType.agriculture, EconomicRelationship.buys, commodityType.agriculturalMedicines),

                // Hydrogen Fuel
                new CultureDbModel( cultureType.refinery, EconomicRelationship.sells, commodityType.hydrogenFuel),
                new CultureDbModel( cultureType.highTech, EconomicRelationship.buys, commodityType.hydrogenFuel),
                new CultureDbModel( cultureType.industrial, EconomicRelationship.buys, commodityType.hydrogenFuel),
                new CultureDbModel( cultureType.agriculture, EconomicRelationship.buys, commodityType.hydrogenFuel),
                new CultureDbModel( cultureType.refinery, EconomicRelationship.buys, commodityType.hydrogenFuel),
                new CultureDbModel( cultureType.extraction, EconomicRelationship.buys, commodityType.hydrogenFuel),

                // Explosives
                new CultureDbModel( cultureType.refinery, EconomicRelationship.sells, commodityType.explosives),
                new CultureDbModel( cultureType.extraction, EconomicRelationship.buys, commodityType.explosives),

                // Mineral Oil
                new CultureDbModel( cultureType.agriculture, EconomicRelationship.sells, commodityType.mineralOil),
                new CultureDbModel( cultureType.refinery, EconomicRelationship.buys, commodityType.mineralOil),

                // Consumer Tech
                new CultureDbModel( cultureType.highTech, EconomicRelationship.sells, commodityType.consumerTechnology),
                new CultureDbModel( cultureType.highTech, EconomicRelationship.buys, commodityType.consumerTechnology),
                new CultureDbModel( cultureType.industrial, EconomicRelationship.buys, commodityType.consumerTechnology),
                new CultureDbModel( cultureType.agriculture, EconomicRelationship.buys, commodityType.consumerTechnology),
                new CultureDbModel( cultureType.refinery, EconomicRelationship.buys, commodityType.consumerTechnology),
                new CultureDbModel( cultureType.extraction, EconomicRelationship.buys, commodityType.consumerTechnology),

                // Clothing
                new CultureDbModel( cultureType.industrial, EconomicRelationship.sells, commodityType.clothing),
                new CultureDbModel( cultureType.highTech, EconomicRelationship.buys, commodityType.clothing),
                new CultureDbModel( cultureType.industrial, EconomicRelationship.buys, commodityType.clothing),
                new CultureDbModel( cultureType.agriculture, EconomicRelationship.buys, commodityType.clothing),
                new CultureDbModel( cultureType.refinery, EconomicRelationship.buys, commodityType.clothing),
                new CultureDbModel( cultureType.extraction, EconomicRelationship.buys, commodityType.clothing),

                // Domestic Appliances
                new CultureDbModel( cultureType.industrial, EconomicRelationship.sells, commodityType.domesticAppliances),
                new CultureDbModel( cultureType.highTech, EconomicRelationship.buys, commodityType.domesticAppliances),
                new CultureDbModel( cultureType.industrial, EconomicRelationship.buys, commodityType.domesticAppliances),
                new CultureDbModel( cultureType.agriculture, EconomicRelationship.buys, commodityType.domesticAppliances),
                new CultureDbModel( cultureType.refinery, EconomicRelationship.buys, commodityType.domesticAppliances),
                new CultureDbModel( cultureType.extraction, EconomicRelationship.buys, commodityType.domesticAppliances),

                // Liquor
                new CultureDbModel( cultureType.agriculture, EconomicRelationship.sells, commodityType.liquor),
                new CultureDbModel( cultureType.agriculture, EconomicRelationship.sells, commodityType.tobacco),

            };
        }

        private IEnumerable<CommodityDbModel> PopulateCommodities()
        {
            return new List<CommodityDbModel>()
            {
                new CommodityDbModel (
                        cat:  categoryType.chemicals,
                        type: commodityType.agriculturalMedicines
                    ),
                new CommodityDbModel (
                        cat:  categoryType.chemicals,
                        type: commodityType.explosives
                    ),
                new CommodityDbModel (
                        cat:  categoryType.chemicals,
                        type: commodityType.hydrogenFuel
                    ),
                new CommodityDbModel (
                        cat:  categoryType.chemicals,
                        type: commodityType.mineralOil
                    ),
                new CommodityDbModel (
                        cat:  categoryType.consumerItems,
                        type: commodityType.consumerTechnology
                    ),
                new CommodityDbModel (
                        cat:  categoryType.consumerItems,
                        type: commodityType.clothing
                    ),
                new CommodityDbModel (
                        cat:  categoryType.consumerItems,
                        type: commodityType.domesticAppliances
                    ),
                new CommodityDbModel (
                        cat:  categoryType.drugs,
                        type: commodityType.basicNarcotics
                    ),
                new CommodityDbModel (
                        cat:  categoryType.drugs,
                        type: commodityType.beer
                    ),
                new CommodityDbModel (
                        cat:  categoryType.drugs,
                        type: commodityType.tobacco
                    ),
                new CommodityDbModel (
                        cat:  categoryType.drugs,
                        type: commodityType.liquor
                    ),
                new CommodityDbModel (
                        cat:  categoryType.drugs,
                        type: commodityType.wine
                    ),
                new CommodityDbModel (
                        cat:  categoryType.foods,
                        type: commodityType.animalMeat
                    ),
                new CommodityDbModel (
                        cat:  categoryType.foods,
                        type: commodityType.coffee
                    ),
                new CommodityDbModel (
                        cat:  categoryType.foods,
                        type: commodityType.fish
                    ),
                new CommodityDbModel (
                        cat:  categoryType.foods,
                        type: commodityType.fruit
                    ),
                new CommodityDbModel (
                        cat:  categoryType.foods,
                        type: commodityType.grain
                    ),
                new CommodityDbModel (
                        cat:  categoryType.foods,
                        type: commodityType.tea
                    ),
                new CommodityDbModel (
                        cat:  categoryType.foods,
                        type: commodityType.syntheticMeat
                    ),
                new CommodityDbModel (
                        cat:  categoryType.foods,
                        type: commodityType.foodCatridges
                    ),
                new CommodityDbModel (
                        cat:  categoryType.foods,
                        type: commodityType.algae
                    ),
                new CommodityDbModel (
                        cat:  categoryType.industrialMaterial,
                        type: commodityType.polymers
                    ),
                new CommodityDbModel (
                        cat:  categoryType.industrialMaterial,
                        type: commodityType.semiConductors
                    ),
                new CommodityDbModel (
                        cat:  categoryType.industrialMaterial,
                        type: commodityType.superConductors
                    ),
                new CommodityDbModel (
                        cat:  categoryType.machinery,
                        type: commodityType.marineSupplies
                    ),
                new CommodityDbModel (
                        cat:  categoryType.machinery,
                        type: commodityType.cropHarvesters
                    ),
                new CommodityDbModel (
                        cat:  categoryType.machinery,
                        type: commodityType.mineralExtractors
                    ),
                new CommodityDbModel (
                        cat:  categoryType.machinery,
                        type: commodityType.heliostaticFurnaces
                    ),
                new CommodityDbModel (
                        cat:  categoryType.medicines,
                        type: commodityType.basicMedicines
                    ),
                new CommodityDbModel (
                        cat:  categoryType.medicines,
                        type: commodityType.progenitorCells
                    ),
                new CommodityDbModel (
                        cat:  categoryType.medicines,
                        type: commodityType.combatStabilisers
                    ),
                new CommodityDbModel (
                        cat:  categoryType.medicines,
                        type: commodityType.performanceEnhancers
                    ),
                new CommodityDbModel (
                        cat:  categoryType.metals,
                        type: commodityType.paladium
                    ),
                new CommodityDbModel (
                        cat:  categoryType.metals,
                        type: commodityType.silver
                    ),
                new CommodityDbModel (
                        cat:  categoryType.metals,
                        type: commodityType.gold
                    ),
                new CommodityDbModel (
                        cat:  categoryType.metals,
                        type: commodityType.copper
                    ),
                new CommodityDbModel (
                        cat:  categoryType.metals,
                        type: commodityType.aluminum
                    ),
                new CommodityDbModel (
                        cat:  categoryType.metals,
                        type: commodityType.beryllium
                    ),
                new CommodityDbModel (
                        cat:  categoryType.metals,
                        type: commodityType.indium
                    ),
                new CommodityDbModel (
                        cat:  categoryType.metals,
                        type: commodityType.lithium
                    ),
                new CommodityDbModel (
                        cat:  categoryType.metals,
                        type: commodityType.tantalum
                    ),
                new CommodityDbModel (
                        cat:  categoryType.metals,
                        type: commodityType.titanium
                    ),
                new CommodityDbModel (
                        cat:  categoryType.metals,
                        type: commodityType.uranium
                    ),
                new CommodityDbModel (
                        cat:  categoryType.minerals,
                        type: commodityType.gallium
                    ),
                new CommodityDbModel (
                        cat:  categoryType.minerals,
                        type: commodityType.lepidolite
                    ),
                new CommodityDbModel (
                        cat:  categoryType.minerals,
                        type: commodityType.gallite
                    ),
                new CommodityDbModel (
                        cat:  categoryType.minerals,
                        type: commodityType.indite
                    ),
                new CommodityDbModel (
                        cat:  categoryType.minerals,
                        type: commodityType.uranimate
                    ),
                new CommodityDbModel (
                        cat:  categoryType.minerals,
                        type: commodityType.bertrandite
                    ),
                new CommodityDbModel (
                        cat:  categoryType.minerals,
                        type: commodityType.coltan
                    ),
                new CommodityDbModel (
                        cat:  categoryType.minerals,
                        type: commodityType.rutile
                    ),
                new CommodityDbModel (
                        cat:  categoryType.technology,
                        type: commodityType.advancedCatalysers
                    ),
                new CommodityDbModel (
                        cat:  categoryType.technology,
                        type: commodityType.animalMonitors
                    ),
                new CommodityDbModel (
                        cat:  categoryType.technology,
                        type: commodityType.aquaponicSystems
                    ),
                new CommodityDbModel (
                        cat:  categoryType.technology,
                        type: commodityType.autoFabricators
                    ),
                new CommodityDbModel (
                        cat:  categoryType.technology,
                        type: commodityType.bioReducingLichen
                    ),
                new CommodityDbModel (
                        cat:  categoryType.technology,
                        type: commodityType.computerComponents
                    ),
                new CommodityDbModel (
                        cat:  categoryType.technology,
                        type: commodityType.HESuits
                    ),
                new CommodityDbModel (
                        cat:  categoryType.technology,
                        type: commodityType.resonatingSeparators
                    ),
                new CommodityDbModel (
                        cat:  categoryType.technology,
                        type: commodityType.robotics
                    ),
                new CommodityDbModel (
                        cat:  categoryType.technology,
                        type: commodityType.terrainEnrichmentSystems
                    ),
                new CommodityDbModel (
                        cat:  categoryType.textiles,
                        type: commodityType.leather
                    ),
                new CommodityDbModel (
                        cat:  categoryType.textiles,
                        type: commodityType.naturalFabrics
                    ),
                new CommodityDbModel (
                        cat:  categoryType.textiles,
                        type: commodityType.syntheticFabrics
                    ),
                new CommodityDbModel (
                        cat:  categoryType.weapons,
                        type: commodityType.battleWeapons
                    ),
                new CommodityDbModel (
                        cat:  categoryType.weapons,
                        type: commodityType.personalWeapons
                    ),
                new CommodityDbModel (
                        cat:  categoryType.weapons,
                        type: commodityType.reactiveArmor
                    ),
                new CommodityDbModel (
                        cat:  categoryType.weapons,
                        type: commodityType.nonLethalWeapons
                    ),
                new CommodityDbModel (
                        cat:  categoryType.waste,
                        type: commodityType.bioWaste
                    ),
                new CommodityDbModel (
                        cat:  categoryType.waste,
                        type: commodityType.scrap
                    )
            };

            

        }
    }
}
