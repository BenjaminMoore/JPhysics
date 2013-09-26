﻿namespace JPhysics.Unity
{
    using Collision.Shapes;
    using UnityEngine;

    [AddComponentMenu("JPhysics/Box Collider")]
    public sealed class JBoxCollider : JRigidbody
    {
        public Vector3 Size = Vector3.one;

        private void Awake()
        {
            Shape = new BoxShape((Vector3.Scale(Size,transform.localScale).ConvertToJVector()));
        }
    }
}
