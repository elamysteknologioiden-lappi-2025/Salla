namespace VRTK.Examples
{
    using UnityEngine;

    public class Whirlygig : VRTK_InteractableObject
    {
        float spinSpeed = 0f;


        public override void StartUsing(VRTK_InteractUse usingObject)
        {

            base.StartUsing(usingObject);
            spinSpeed = 360f;
        }

        public override void StopUsing(VRTK_InteractUse usingObject)
        {

            base.StopUsing(usingObject);
            GetComponent<Rigidbody>().isKinematic = false;
            spinSpeed = 0f;
        }

        protected void Start()
        {

        }

        protected override void Update()
        {
            base.Update();
        }
    }
}