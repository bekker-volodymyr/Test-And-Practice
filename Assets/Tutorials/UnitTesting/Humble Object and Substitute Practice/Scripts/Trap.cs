using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PracticeProject.UnitTesting.HOSubPractice
{
    public class Trap
    {
        public Trap() 
        {
            
        }

        public void HandleCollision(ICharacter character, TrapTarget target)
        {
            if (character.IsPlayer)
            {
                if (target == TrapTarget.Player)
                    character.Health--;
            }
            else
            {
                if(target == TrapTarget.NPC)
                    character.Health--;
            }
            Debug.Log(character.Health);
        }
    }
}