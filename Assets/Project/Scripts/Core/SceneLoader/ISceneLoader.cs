using Core.thirdparty.RSG.Promise.v1._3._0._0;
using UnityEngine.SceneManagement;

namespace Core.SceneLoader
{
    public interface ISceneLoader
    {
        IPromise LoadScene(string sceneName);
        IPromise UnloadScene(string sceneName);
        IPromise UnloadScene(Scene sceneName);
    }
}
