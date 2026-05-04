class Lasagna
{
    private int expectedTimeInOven = 40;
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => expectedTimeInOven; 

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int bakingTime) => expectedTimeInOven - bakingTime;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers) => layers * 2;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int bakingTime) => layers * 2 + bakingTime;
}
