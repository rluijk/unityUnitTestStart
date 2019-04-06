using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayterTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void PlayerEnteringTrap_RecudesHealthByOne()
        {

            Trap trap = new Trap();
            ICharacterMover characterMover = Substitute.For<ICharacterMover>();
            trap.HandleCharacterEntered(characterMover);
            Debug.Log("health: " + characterMover.Health);
            Assert.AreEqual(-1,characterMover.Health);

        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
