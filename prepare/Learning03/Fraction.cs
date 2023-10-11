using System;

/*
Sean Reading
10/11/2023
Fraction Class
*/

class srFraction
{
    private int srTop;
    private int srBottom;

    //Constructors
    public srFraction()
    {
        this.srSetTop(0);
        this.srSetBottom(1);
    }
    public srFraction(int srWholeNumber)
    {
        this.srSetTop(srWholeNumber);
        this.srSetBottom(1);

    }
    public srFraction(int srTopNum, int srBottomNum)
    {
        this.srSetTop(srTopNum);
        this.srSetBottom(srBottomNum);
    }

    //Setters
    private void srSetTop(int srNewTop)
    {
        srTop = srNewTop;
    }
    private void srSetBottom(int srNewBottom)
    {
        srBottom = srNewBottom;
    }

    //Getters
    public int srGetTop()
    {
        return srTop;
    }
    public int srGetBottom()
    {
        return srBottom;
    }

    //return the fraction as a string
    public string srGetFractionAsString()
    {
        return srTop + "/" + srBottom;
    }

    //convert the fraction to a decimal value
    public float srGetFractionAsDecimal()
    {
        float srTempBottom = srBottom;
        return srTop / srTempBottom;
    }
}