using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using PracticeProject.UnitTesting;
using NSubstitute;

public class player_movement
{
    [UnityTest]
    public IEnumerator with_positive_vertical_input_moves_forward()
    {
        GameObject playerGO = new GameObject("Player");
        Player player = playerGO.AddComponent<Player>();
        player.PlayerInput = Substitute.For<IPlayerInput>();

        player.PlayerInput.Vertical.Returns(1f);

        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(playerGO.transform);
        cube.transform.localPosition = Vector3.zero;

        yield return new WaitForSeconds(.3f);

        Assert.IsTrue(player.transform.position.z > 0f);
        Assert.AreEqual(0f, player.transform.position.y);
        Assert.AreEqual(0f, player.transform.position.x);
    }
}
