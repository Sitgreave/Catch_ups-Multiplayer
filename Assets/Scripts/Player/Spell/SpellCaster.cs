
using UnityEngine;

public class SpellCaster : MonoBehaviour
{
    [SerializeField] private Charge _charge;

    public void Charge()
    {
        _charge.Cast();
    }
}
