// Slide Object Control Action|ObjectControlActions|25010
namespace VRTK
{
	using UnityEngine;

	/// <summary>
	/// The Slide Object Control Action script is used to slide the controlled GameObject around the scene when changing the axis.
	/// </summary>
	/// <remarks>
	/// The effect is a smooth sliding motion in forward and sideways directions to simulate walking.
	/// </remarks>
	/// <example>
	/// `VRTK/Examples/017_CameraRig_TouchpadWalking` has a collection of walls and slopes that can be traversed by the user with the touchpad. There is also an area that can only be traversed if the user is crouching.
	///
	/// To enable the Slide Object Control Action, ensure one of the `TouchpadControlOptions` children (located under the Controller script alias) has the `Slide` control script active.
	/// </example>
	[AddComponentMenu("VRTK/Scripts/Locomotion/Object Control Actions/PLABVRControllerAction")]
	public class PLABVRControllerAction : VRTK_BaseObjectControlAction
	{

		public pLAB_DimRotation dimRoation;

		protected override void Process(GameObject controlledGameObject, Transform directionDevice, Vector3 axisDirection, float axis, float deadzone, bool currentlyFalling, bool modifierActive)
		{
			if (Mathf.Abs (axis) > 0.5f) {
				dimRoation.DimRotate (axis);
			}
		}

	
	}
}