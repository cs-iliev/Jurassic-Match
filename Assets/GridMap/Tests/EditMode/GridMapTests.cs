using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GridMapTests
{
    GridMap grid;

    [Test]
    public void GridMapGetValue()
    {
        grid = new GridMap(4, 2, 10f, new Vector3(20, 0, 0));
        Assert.AreEqual(grid.GetValue(0, 0), 0);
    }

    [Test]
    public void GridMapSetValue()
    {
        grid = new GridMap(4, 2, 10f, new Vector3(20, 0, 0));
        grid.SetValue(0, 0, 56);
        Assert.AreEqual(grid.GetValue(0, 0), 56);
    }

    [Test]
    public void GridMapGetValueWorldPosition()
    {
        grid = new GridMap(4, 2, 10f, new Vector3(0, 0, 0));
        Assert.AreEqual(grid.GetValue(new Vector3(.5f, .5f, 0)), 0);

        grid.SetValue(0, 0, 56);
        Assert.AreEqual(grid.GetValue(new Vector3(5, 5, 0)), 56);
    }
}
