using UnityEngine;

namespace EmuLib.Utils.Camera
{
	internal class Free : FreeCamera
	{
		private void FixedUpdate()
		{
			Transform transform1 = transform;
			GameObject o = EmuInstance.Player.gameObject;
			Vector3 position = transform1.position;
			o.transform.position = new Vector3(position.x, position.y - 2f, position.z);
			o.transform.rotation = transform1.rotation;
		}
	}
}