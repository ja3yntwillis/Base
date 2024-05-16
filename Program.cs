using TestConsoleApp.BaseCalculations;
using TestConsoleApp.PlantPotting.FruitPlants;
using TestConsoleApp.Skeleton;

static void main()
{

   //abs
    Guava guava = new Guava();

    guava.GetSoil();
    guava.GetPot();

    //interface
    pear pear = new pear();

    pear.GetPot();
    pear.GetSoil();

}


main();
