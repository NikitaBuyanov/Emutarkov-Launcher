using EFT.HealthSystem;
using EmuLib.Utils.HTTP;
using EmuLib.Utils.Reflection;
using PlayerStatesInterface = GInterface107;

namespace EmuLib.Utils.Player
{
	internal static class HealthStateUtils
	{
		public static void OnHealthChangedEvent(EBodyPart bodyPart, float diff, PlayerStatesInterface effect)
		{
			float partHealth = EmuInstance.Player.HealthController.GetBodyPartHealth(bodyPart).Current;
			var requestData = new
			{
				type = "HealthChanged",
				bodyPart,
				value = partHealth
			};

			SendRequest(requestData);
		}

		public static void OnHydrationChangedEvent(float diff)
		{
			var requestData = new
			{
				type = "HydrationChanged",
				diff
			};

			SendRequest(requestData);
		}

		public static void OnEnergyChangedEvent(float diff)
		{
			var requestData = new
			{
				type = "EnergyChanged",
				diff
			};

			SendRequest(requestData);
		}

		public static void OnEffectAddedEvent(PlayerStatesInterface effect)
		{
			if (effect is null)
			{
				return;
			}

			OnHealthChangedEvent(effect.BodyPart, 0, effect);

			var requestData = new
			{
				type = "EffectAdded",
				bodyPart = effect.BodyPart,
				effectType = effect.DisplayableVariations[0].Type
			};

			SendRequest(requestData);
		}

		public static void OnEffectRemovedEvent(PlayerStatesInterface effect)
		{
			if (effect is null)
			{
				return;
			}

			OnHealthChangedEvent(effect.BodyPart, 0, effect);

			var requestData = new
			{
				type = "EffectRemoved",
				bodyPart = effect.BodyPart,
				effectType = effect.DisplayableVariations[0].Type
			};

			SendRequest(requestData);
		}

		public static void OnBodyPartDestroyedEvent(EBodyPart bodyPart, EDamageType damageType)
		{
			var requestData = new
			{
				type = "BodyPartDestroyed",
				bodyPart,
				damageType
			};

			SendRequest(requestData);
		}

		public static void OnDiedEvent(EDamageType damageType)
		{
			var requestData = new
			{
				type = "Died",
				damageType
			};

			SendRequest(requestData);
		}

		private static void SendRequest(object requestData)
		{
			new HttpUtils.Create(ClientAppUtils.GetSessionId()).Post("/player/health/events", requestData.ToJson(), true);
		}
	}
}