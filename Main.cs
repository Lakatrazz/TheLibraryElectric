﻿using System.Threading;
using TheLibraryElectric.Markers;
using TheLibraryElectric.Misc;
using TheLibraryElectric.Rigidbodies;
using TheLibraryElectric.Signals;
using TheLibraryElectric.PlayerUtil;
using TheLibraryElectric.Water;
using MelonLoader;
using UnityEngine;

namespace TheLibraryElectric
{
    public class Main : MelonMod
    {
        internal const string Name = "The Library Electric";
        internal const string Description = "See how IL2CPP breaks the mod.";
        internal const string Author = "CarrionAndOn + BugoBug";
        internal const string Company = "Weather Electric";
        internal const string Version = "1.2.0";
        internal const string DownloadLink = "https://bonelab.thunderstore.io/package/CarrionAndOn/TheLibraryElectric/";
        public override void OnInitializeMelon()
        {
            ModConsole.Setup(LoggerInstance);
            Preferences.Setup();
            ModConsole.Msg("Injecting the fields with the fieldinjector which injects fields, crazy isnt it", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<DoNotFreeze>();
            ModConsole.Msg("Hopefully injected DoNotFreeze", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<DoNotDestroy>();
            ModConsole.Msg("Hopefully injected DoNotDestroy", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<RecieveSignal>();
            ModConsole.Msg("Hopefully injected RecieveSignal", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<SendSignal>();
            ModConsole.Msg("Hopefully injected SendSignal", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<RigManagerControl>();
            ModConsole.Msg("Hopefully injected RigManagerControl", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<FreezeRigidbodies>();
            ModConsole.Msg("Hopefully injected FreezeRigidbodies", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<DestroyOnCollision>();
            ModConsole.Msg("Hopefully injected DestroyOnCollision", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<ExplodeButBetter>();
            ModConsole.Msg("Hopefully injected ExplodeButBetter", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<TimescaleController>();
            ModConsole.Msg("Hopefully injected TimescaleController", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<UpdateTMP>();
            ModConsole.Msg("Hopefully injected UpdateTMP", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<VoidCounterObject>();
            ModConsole.Msg("Hopefully injected VoidCounterObject", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<RBGravityManager>();
            ModConsole.Msg("Hopefully injected RBGravityManager", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<GravityChamber>();
            ModConsole.Msg("Hopefully injected GravityChamber", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<RagdollZone>();
            ModConsole.Msg("Hopefully injected RagdollZone", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<ForceZone>();
            ModConsole.Msg("Hopefully injected ForceZone", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<SpawnOnTriggerEnter>();
            ModConsole.Msg("Hopefully injected SpawnOnTriggerEnter", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<SpawnCrateOnTriggerEnter>();
            ModConsole.Msg("Hopefully injected SpawnCrateOnTriggerEnter", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<DespawnPooledObject>();
            ModConsole.Msg("Hopefully injected DespawnPooledObject", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<RandomAudioPlayer>();
            ModConsole.Msg("Hopefully injected RandomAudioPlayer", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<IgnoreRigidbody>();
            ModConsole.Msg("Hopefully injected IgnoreRigidbody", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<RbBuoyancyManager>();
            ModConsole.Msg("Hopefully injected RbBuoyancyManager", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<WaterZone>();
            ModConsole.Msg("Hopefully injected WaterZone", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<ItemThrower>();
            ModConsole.Msg("Hopefully injected ItemThrower", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<SignalTrigger>();
            ModConsole.Msg("Hopefully injected SignalTrigger", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<SignalTriggerer>();
            ModConsole.Msg("Hopefully injected SignalTriggerer", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<HandMonitor>();
            ModConsole.Msg("Hopefully injected SwimmingController", LoggingMode.DEBUG);
            FieldInjector.SerialisationHandler.Inject<SwimmingController>();
            ModConsole.Msg("Hopefully injected HandMonitor", LoggingMode.DEBUG);
            ModConsole.Msg("All fields are probably injected. I can't tell since this isn't async so I can't slap a bool on it.", LoggingMode.DEBUG);
            ModConsole.Msg("Doing Jevillib stuff", LoggingMode.DEBUG);
        }
        public override void OnLateInitializeMelon()
        {
            Thread initializationThread = new Thread(new ThreadStart(async () =>
            {
                await ModStats.IncrementLaunch();
                if (!PlayerPrefs.HasKey("TheLibraryElectricLaunch"))
                    await ModStats.IncrementUser();
                PlayerPrefs.TrySetInt("TheLibraryElectricLaunch", 1);
            }));

            initializationThread.Start();
        }
    }
}