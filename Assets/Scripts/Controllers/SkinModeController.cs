using Enums;
using UnityEngine;

namespace Controllers
{
    [CreateAssetMenu(fileName = "SkinModeController", menuName = "Controllers/SkinModeController")]
    public class SkinModeController : ScriptableObject
    {
        public SkinType SkinType = SkinType.FOOD;
    }
}