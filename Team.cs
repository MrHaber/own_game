using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Team
{
    private string name;
    private string units;
    private string[] unitsList;
    private int points;

    public Team(string name, string units, int points)
    {
        this.name = name;
        this.points = points;
        this.units = units;
    }
    public Team(string name, string[] unitsList, int points)
    {
        this.name = name;
        this.points = points;
        this.unitsList = unitsList;
    }

    public void increasePoints(int value)
    {
        this.points += value;
    }
    public string Units
    {
        get { return units; }
        set { units = value; }
    }

    public string[] UnitsList
    {
        get { return unitsList; }
        set { unitsList = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Points
    {
        get { return points; }
        set { points = value; }
    }
}
