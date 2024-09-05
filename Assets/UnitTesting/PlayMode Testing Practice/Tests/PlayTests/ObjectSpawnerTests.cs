using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using PracticeProject.UnitTesting.PMTestingPractice;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

public class ObjectSpawnerTests
{
    [UnityTest]
    public IEnumerator Instantiate_GameObject_From_Prefab()
    {
        var objPrefab = Resources.Load("Tests/ObjPrefab");
        var objSpawner = new GameObject().AddComponent<ObjectSpawner>();
        objSpawner.Construct(objPrefab, 0, 1);

        yield return null;

        var spawnedObj = GameObject.FindWithTag("Obj");
        var prefabOfSpawnedEnemy = PrefabUtility.GetCorrespondingObjectFromSource(spawnedObj);

        Assert.AreEqual(objPrefab, prefabOfSpawnedEnemy);
    }

    private ObjectSpawner CreateSpawner(Object objPrefab, int interval)
    {
        var objSpawner = new GameObject().AddComponent<ObjectSpawner>();
        objSpawner.Construct(objPrefab, interval, 1);
        return objSpawner;
    }

    [UnityTest]
    public IEnumerator Instantiate_GameObject_At_Random_Position_On_Circle_Boundary()
    {
        var objPrefab = Resources.Load("Tests/ObjPrefab");
        var objSpawner = new GameObject().AddComponent<ObjectSpawner>();
        objSpawner.Construct(objPrefab, 0, 1);
        var random = Substitute.For<System.Random>();
        random.Next(Arg.Any<int>(), Arg.Any<int>()).Returns(270);
        objSpawner.Random = random;

        yield return null;

        var spawnedObj = GameObject.FindWithTag("Obj");
        var expectedPosition = new Vector3(0f, 0f, -1f);

        Assert.AreEqual(expectedPosition, spawnedObj.transform.position);
    }

    [UnityTest]
    public IEnumerator Instatiations_Occur_On_An_Interval()
    {
        var objPrefab = Resources.Load("Tests/ObjPrefab");
        var objSpawner = new GameObject().AddComponent<ObjectSpawner>();
        objSpawner.Construct(objPrefab, 1, 1);

        yield return new WaitForSeconds(0.75f);

        var spawnedObj = GameObject.FindWithTag("Obj");

        Assert.IsNull(spawnedObj);
    }

    [TearDown]
    public void AfterEveryTest()
    {
        foreach (var gameObj in GameObject.FindGameObjectsWithTag("Obj"))
        {
            Object.Destroy(gameObj);
        }
        foreach (var gameObj in Object.FindObjectsOfType<ObjectSpawner>())
        {
            Object.Destroy(gameObj);
        }
    }
}
