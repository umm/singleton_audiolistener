using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests {

    public class SingletonAudioListenerTest {

        [UnityTest]
        public IEnumerator BasicTest() {
            SceneManager.LoadScene("Tests/Scenes/Test", LoadSceneMode.Single);
            yield return new WaitForEndOfFrame();
            yield return new WaitForEndOfFrame();
            Assert.AreEqual(1, Object.FindObjectsOfType<AudioListener>().Length);
            SceneManager.LoadScene("Tests/Scenes/Test", LoadSceneMode.Additive);
            yield return new WaitForEndOfFrame();
            yield return new WaitForEndOfFrame();
            Assert.AreEqual(1, Object.FindObjectsOfType<AudioListener>().Length);
        }

    }

}