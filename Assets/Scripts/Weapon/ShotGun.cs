using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : Weapon
{
    private float _accuracyX;
    private float _accuracyY;
    private int _bulletsCount;

    public override void Shoot(Transform shootPoint)
    {


        _bulletsCount = 5;

        for (int i = 0; i < _bulletsCount; i++)
        {
            _accuracyX = Random.Range(-0.3f, 0.3f);
            _accuracyY = Random.Range(-0.3f, 0.3f);
            Instantiate(Bullet, shootPoint.position + new Vector3(_accuracyX, _accuracyY, shootPoint.position.z), Quaternion.identity);
        }
    }
}
