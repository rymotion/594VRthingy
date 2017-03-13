[master 9e3f940] Started gradle for new Android application/ activities
 362 files changed, 12208 insertions(+), 5336 deletions(-)
 create mode 100644 GoogleVRForUnity.unitypackage
 rewrite README.md (79%)
 rewrite SW_VR/Library/ScriptAssemblies/Assembly-CSharp-Editor.dll (62%)
 rewrite SW_VR/Library/ScriptAssemblies/Assembly-CSharp.dll (81%)
 rewrite SW_VR/Library/ScriptAssemblies/Assembly-CSharp.dll.mdb (60%)
 rewrite SW_VR/Library/metadata/06/061b4882add4e49f58cf2e6902bb627c.info (91%)
 rewrite SW_VR/Library/metadata/0f/0f9dae433a03e46f3851f679a1705c68.info (77%)
 rewrite SW_VR/Library/metadata/15/15f2643d32e75437aa4b3be3801805db.info (85%)
 rewrite SW_VR/Library/metadata/16/1656b352e0a09492986dee6770378cb9 (94%)
 rewrite SW_VR/Library/metadata/16/1656b352e0a09492986dee6770378cb9.info (96%)
 rewrite SW_VR/Library/metadata/1f/1fde87553eacd4f0fb71e60916f53f1c.info (90%)
 rewrite SW_VR/Library/metadata/22/226cfc1dcfd9df449a7c4e33729e0922.info (80%)
 rewrite SW_VR/Library/metadata/29/29f18475c23f79f47be8049675d32034 (96%)
 rewrite SW_VR/Library/metadata/2d/2d89a5f92f03449f2bd6c28c914115fc (77%)
 rewrite SW_VR/Library/metadata/2e/2ed723af2786f7e4c85a3ed4f5c42cda (82%)
 rewrite SW_VR/Library/metadata/2e/2ed723af2786f7e4c85a3ed4f5c42cda.info (89%)
 rewrite SW_VR/Library/metadata/2f/2f06e3a2ab3b94effb4558e4b98186d4.info (91%)
 rewrite SW_VR/Library/metadata/30/30c0a1ca424d6a9448aa4938bd949927 (81%)
 rewrite SW_VR/Library/metadata/30/30c0a1ca424d6a9448aa4938bd949927.info (92%)
 rewrite SW_VR/Library/metadata/33/33fe2a867f53b4dd7b47d13503efb4de (65%)
 rewrite SW_VR/Library/metadata/34/34ecdc1489a3bb84fa16f97d610026e3 (96%)
 rewrite SW_VR/Library/metadata/36/36597cf9c1ebe400c99c9affa94cfd24 (65%)
 rewrite SW_VR/Library/metadata/3c/3ce8942d2a58c4ff08924b205074aebb.info (92%)
 rewrite SW_VR/Library/metadata/40/40ca73587710f45868778360ee31dbb5.info (83%)
 rewrite SW_VR/Library/metadata/42/42293f5648d5cb0429cc171280266d61 (94%)
 rewrite SW_VR/Library/metadata/42/42293f5648d5cb0429cc171280266d61.info (97%)
 rewrite SW_VR/Library/metadata/42/42991f18eb18a4324a178fd6ee08eb56.info (89%)
 rewrite SW_VR/Library/metadata/43/438798dacf68a89468a45915a37bf75e (82%)
 rewrite SW_VR/Library/metadata/43/438798dacf68a89468a45915a37bf75e.info (97%)
 rewrite SW_VR/Library/metadata/45/45f87acbc47a08e4da669c7534a8c489.info (91%)
 rewrite SW_VR/Library/metadata/4a/4a3a7a9e2f6a6de4a9fed0760bc134c2 (93%)
 rewrite SW_VR/Library/metadata/4a/4a3a7a9e2f6a6de4a9fed0760bc134c2.info (96%)
 rewrite SW_VR/Library/metadata/56/567e94a5a79ab418cb17c44196d5f634.info (90%)
 rewrite SW_VR/Library/metadata/59/5970a68ff7c4d554e8e9f4495c1a534f (81%)
 rewrite SW_VR/Library/metadata/59/5970a68ff7c4d554e8e9f4495c1a534f.info (91%)
 rewrite SW_VR/Library/metadata/64/64dec5012825f402c800f94c144d8b94.info (86%)
 rewrite SW_VR/Library/metadata/66/66b9762b95d89e943b6194a9d8ce0d0b (81%)
 rewrite SW_VR/Library/metadata/66/66b9762b95d89e943b6194a9d8ce0d0b.info (91%)
 rewrite SW_VR/Library/metadata/68/68abcd70597a95242b44f8873cf0b248 (94%)
 rewrite SW_VR/Library/metadata/68/68abcd70597a95242b44f8873cf0b248.info (98%)
 rewrite SW_VR/Library/metadata/69/69662f4420b8ccd4a8749fd5ca2330d7 (94%)
 rewrite SW_VR/Library/metadata/69/69662f4420b8ccd4a8749fd5ca2330d7.info (98%)
 rewrite SW_VR/Library/metadata/69/69fbbc1d67f00c24ea8987d0ae0b650e (94%)
 rewrite SW_VR/Library/metadata/69/69fbbc1d67f00c24ea8987d0ae0b650e.info (98%)
 rewrite SW_VR/Library/metadata/6b/6b3496d4aff7d4a4bbb422c852f0f992 (81%)
 rewrite SW_VR/Library/metadata/6b/6b3496d4aff7d4a4bbb422c852f0f992.info (89%)
 rewrite SW_VR/Library/metadata/6d/6da5cd89204da99468e34a61cc7ad99d.info (78%)
 rewrite SW_VR/Library/metadata/72/72867935ab9d7264ba8abb14b1f860b2.info (81%)
 rewrite SW_VR/Library/metadata/74/74bc48c745f664fcf88ec5f00e283f88.info (95%)
 rewrite SW_VR/Library/metadata/7a/7a26379ecb2d64048b1af14e822eecc3.info (62%)
 rewrite SW_VR/Library/metadata/7a/7ab9293d5cae04e8bb07ea2f84cde353.info (85%)
 rewrite SW_VR/Library/metadata/7c/7cb55fd22281242bb85d103a3b78b161 (82%)
 rewrite SW_VR/Library/metadata/7d/7dcf0df9d8c1946d4bce67c2ab3cbd53.info (90%)
 rewrite SW_VR/Library/metadata/81/815cc5b4a417a40aaa7f9e6ed772833e.info (93%)
 rewrite SW_VR/Library/metadata/84/849a1201bc5802f4ebff7ef40e009af5 (87%)
 rewrite SW_VR/Library/metadata/84/849a1201bc5802f4ebff7ef40e009af5.info (91%)
 rewrite SW_VR/Library/metadata/8a/8ac04e7c42c5d4a88936e5f8de307a72 (82%)
 rewrite SW_VR/Library/metadata/8a/8ac04e7c42c5d4a88936e5f8de307a72.info (87%)
 rewrite SW_VR/Library/metadata/8d/8d146c8220a9a403fa230a9aadf39b48.info (96%)
 rewrite SW_VR/Library/metadata/8e/8e2b5a46da88df34988d7b068cf93af6.info (82%)
 rewrite SW_VR/Library/metadata/9a/9a3be158c14834bdda65a4550f40eb8a.info (84%)
 rewrite SW_VR/Library/metadata/9a/9aa23758b08b6dc4f99a9f85f1f5aeab (94%)
 rewrite SW_VR/Library/metadata/9a/9aa23758b08b6dc4f99a9f85f1f5aeab.info (78%)
 rewrite SW_VR/Library/metadata/9b/9be55a1c895d42a48a59cd0f2fedcb49.info (68%)
 rewrite SW_VR/Library/metadata/a1/a124350e3ac0d4a3fbe3b386d3728545.info (85%)
 rewrite SW_VR/Library/metadata/a2/a2ccce007c3f54b5597ab8cd84b5874b.info (95%)
 rewrite SW_VR/Library/metadata/a5/a5b11d83e4ca647a29b63157bb03e704.info (72%)
 rewrite SW_VR/Library/metadata/ae/ae0d113aeb5fca1469c8d7dc8a4bb0bd (94%)
 rewrite SW_VR/Library/metadata/ae/ae0d113aeb5fca1469c8d7dc8a4bb0bd.info (97%)
 rewrite SW_VR/Library/metadata/b0/b0bcc8d84c8ddb640844056038891bb0.info (82%)
 rewrite SW_VR/Library/metadata/b3/b3b00f546d64da141b0c4384daf0a6e8 (94%)
 rewrite SW_VR/Library/metadata/b3/b3b00f546d64da141b0c4384daf0a6e8.info (77%)
 rewrite SW_VR/Library/metadata/b6/b60af2b1931b9634988eb8e2180bf8ef.info (97%)
 rewrite SW_VR/Library/metadata/b7/b71217cfec4ac4be083722fa718b30ae.info (81%)
 rewrite SW_VR/Library/metadata/b7/b79a0e7e4af574ff3a7ad8066ac7edee.info (86%)
 rewrite SW_VR/Library/metadata/ba/bab2f2af6c9214ff5b7899324e6c72be.info (84%)
 rewrite SW_VR/Library/metadata/bd/bdef42e3d7b4e49bc94f7810c2a99f6c.info (82%)
 rewrite SW_VR/Library/metadata/bf/bf697b22ac8c147ea92dd178550a2ef2.info (96%)
 rewrite SW_VR/Library/metadata/c2/c20d312df18a64252a0a010f1983abbe.info (83%)
 rewrite SW_VR/Library/metadata/c6/c6fa9b6e6263f462580274bacca43bab.info (85%)
 rewrite SW_VR/Library/metadata/d2/d2f0b4e76a2cfb34094a7481fc8ca0dd (96%)
 rewrite SW_VR/Library/metadata/d3/d37560005acc44ccc97be31f65334c29.info (93%)
 rewrite SW_VR/Library/metadata/d3/d3c2d1461ddd43e4b84bb45bdbf1a80a (92%)
 rewrite SW_VR/Library/metadata/d3/d3c2d1461ddd43e4b84bb45bdbf1a80a.info (96%)
 rewrite SW_VR/Library/metadata/d8/d848b45bfff2d43149671c4a9f7678d9.info (89%)
 rewrite SW_VR/Library/metadata/dd/ddcadd5125392914d85174f016a48a9b (94%)
 rewrite SW_VR/Library/metadata/dd/ddcadd5125392914d85174f016a48a9b.info (79%)
 rewrite SW_VR/Library/metadata/de/de8256dcaf71a4236af5c519b1ef596a (86%)
 rewrite SW_VR/Library/metadata/de/de8256dcaf71a4236af5c519b1ef596a.info (94%)
 rewrite SW_VR/Library/metadata/df/dfd2f4c3f586787469dfdb7109c17fd1 (81%)
 rewrite SW_VR/Library/metadata/df/dfd2f4c3f586787469dfdb7109c17fd1.info (91%)
 rewrite SW_VR/Library/metadata/e3/e37412e6819b34a5e9ec972d04b588a3.info (72%)
 rewrite SW_VR/Library/metadata/e4/e4ecb698048ab455babea358c846d5f8 (94%)
 rewrite SW_VR/Library/metadata/e4/e4ecb698048ab455babea358c846d5f8.info (69%)
 rewrite SW_VR/Library/metadata/e5/e555aaa2e768247feb98e3b6ad5958ae (91%)
 rewrite SW_VR/Library/metadata/e5/e555aaa2e768247feb98e3b6ad5958ae.info (89%)
 rewrite SW_VR/Library/metadata/e6/e6ddeda1fe39edb40999d9843b155c69 (88%)
 rewrite SW_VR/Library/metadata/e6/e6ddeda1fe39edb40999d9843b155c69.info (90%)
 rewrite SW_VR/Library/metadata/e6/e6e95194298b043a6ada83e2e167ff9b.info (85%)
 rewrite SW_VR/Library/metadata/e8/e805956ed8a73426789755e17d774bcd.info (95%)
 rewrite SW_VR/Library/metadata/ea/ea559fcf0ef924342a6715af22eb0478.info (96%)
 rewrite SW_VR/Library/metadata/ec/ec0a51638acf0e34ea4a1c05ed1eae73 (94%)
 rewrite SW_VR/Library/metadata/ec/ec0a51638acf0e34ea4a1c05ed1eae73.info (78%)
 rewrite SW_VR/Library/metadata/ec/ec520e5531a5a453d86e37238dfb35ed.info (90%)
 rewrite SW_VR/Library/metadata/ee/ee457da673e1a4bd4a091849d66f5c7e.info (87%)
 rewrite SW_VR/Library/metadata/f7/f7b2b21884d3dde47b683bda4030b250 (82%)
 rewrite SW_VR/Library/metadata/f7/f7b2b21884d3dde47b683bda4030b250.info (97%)
 rewrite SW_VR/Library/metadata/fc/fca470d187a10d240b34644bf64e9c32.info (90%)
 rewrite SW_VR/Library/shadercompiler-UnityShaderCompiler0.log (99%)
 rewrite SW_VR/Library/shadercompiler-UnityShaderCompiler1.log (99%)
 rewrite SW_VR/Library/shadercompiler-UnityShaderCompiler2.log (99%)
 rewrite SW_VR/Library/shadercompiler-UnityShaderCompiler3.log (99%)
 rewrite SW_VR/Library/shadercompiler-UnityShaderCompiler4.log (99%)
 rewrite SW_VR/Library/shadercompiler-UnityShaderCompiler5.log (99%)
 rewrite SW_VR/Library/shadercompiler-UnityShaderCompiler6.log (99%)
 rewrite SW_VR/Library/shadercompiler-UnityShaderCompiler7.log (99%)
 create mode 100644 SW_VR/build.gradle
 create mode 100644 SW_VR/libs/gvr-permissionsupport-release.aar
 create mode 100644 SW_VR/libs/gvr_android_common.aar
 create mode 100644 SW_VR/libs/unity-classes.jar
 create mode 100644 SW_VR/libs/unitygvractivity.aar
 create mode 100644 SW_VR/local.properties
 create mode 100644 SW_VR/proguard-unity.txt
 create mode 100644 SW_VR/src/main/AndroidManifest.xml
 create mode 100644 SW_VR/src/main/assets/bin/Data/67ee2e53086414fbbab2a5edbd544629
 create mode 100755 SW_VR/src/main/assets/bin/Data/Managed/Assembly-CSharp.dll
 create mode 100644 SW_VR/src/main/assets/bin/Data/Managed/Assembly-CSharp.dll.mdb
 create mode 100644 SW_VR/src/main/assets/bin/Data/Managed/Google.ProtocolBuffers.dll
 create mode 100755 SW_VR/src/main/assets/bin/Data/Managed/Mono.Security.dll
 create mode 100644 SW_VR/src/main/assets/bin/Data/Managed/Mono.Security.dll.mdb
 create mode 100755 SW_VR/src/main/assets/bin/Data/Managed/System.Core.dll
 create mode 100644 SW_VR/src/main/assets/bin/Data/Managed/System.Core.dll.mdb
 create mode 100755 SW_VR/src/main/assets/bin/Data/Managed/System.dll
 create mode 100644 SW_VR/src/main/assets/bin/Data/Managed/System.dll.mdb
 create mode 100755 SW_VR/src/main/assets/bin/Data/Managed/UnityEngine.Networking.dll
 create mode 100644 SW_VR/src/main/assets/bin/Data/Managed/UnityEngine.Networking.dll.mdb
 create mode 100755 SW_VR/src/main/assets/bin/Data/Managed/UnityEngine.PlaymodeTestsRunner.dll
 create mode 100644 SW_VR/src/main/assets/bin/Data/Managed/UnityEngine.PlaymodeTestsRunner.dll.mdb
 create mode 100755 SW_VR/src/main/assets/bin/Data/Managed/UnityEngine.UI.dll
 create mode 100644 SW_VR/src/main/assets/bin/Data/Managed/UnityEngine.UI.dll.mdb
 create mode 100644 SW_VR/src/main/assets/bin/Data/Managed/UnityEngine.dll
 create mode 100644 SW_VR/src/main/assets/bin/Data/Managed/UnityEngine.dll.mdb
 create mode 100755 SW_VR/src/main/assets/bin/Data/Managed/mscorlib.dll
 create mode 100644 SW_VR/src/main/assets/bin/Data/Managed/mscorlib.dll.mdb
 create mode 100644 SW_VR/src/main/assets/bin/Data/PlayerConnectionConfigFile
 create mode 100644 SW_VR/src/main/assets/bin/Data/Resources/unity_builtin_extra
 create mode 100644 SW_VR/src/main/assets/bin/Data/beaebe8e7b47e4c0b93b51fad8fb14a2
 create mode 100644 SW_VR/src/main/assets/bin/Data/ca71259be6348485abbe393157796cb8
 create mode 100644 SW_VR/src/main/assets/bin/Data/globalgamemanagers
 create mode 100644 SW_VR/src/main/assets/bin/Data/globalgamemanagers.assets
 create mode 100644 SW_VR/src/main/assets/bin/Data/level0
 create mode 100644 SW_VR/src/main/assets/bin/Data/settings.xml
 create mode 100644 SW_VR/src/main/assets/bin/Data/sharedassets0.assets.split0
 create mode 100644 SW_VR/src/main/assets/bin/Data/sharedassets0.assets.split1
 create mode 100644 SW_VR/src/main/assets/bin/Data/sharedassets0.assets.split2
 create mode 100644 SW_VR/src/main/assets/bin/Data/sharedassets0.assets.split3
 create mode 100644 SW_VR/src/main/assets/bin/Data/sharedassets0.assets.split4
 create mode 100644 SW_VR/src/main/assets/bin/Data/sharedassets0.assets.split5
 create mode 100644 SW_VR/src/main/assets/bin/Data/sharedassets0.assets.split6
 create mode 100644 SW_VR/src/main/assets/bin/Data/sharedassets0.assets.split7
 create mode 100644 SW_VR/src/main/assets/bin/Data/sharedassets0.assets.split8
 create mode 100644 SW_VR/src/main/assets/bin/Data/sharedassets0.assets.split9
 create mode 100644 SW_VR/src/main/assets/bin/Data/sharedassets0.resource
 create mode 100644 SW_VR/src/main/assets/bin/Data/unity default resources
 create mode 100644 SW_VR/src/main/java/com/CSE594/SW/UnityPlayerActivity.java
 create mode 100644 SW_VR/src/main/java/com/CSE594/SW/UnityPlayerNativeActivity.java
 create mode 100644 SW_VR/src/main/java/com/CSE594/SW/UnityPlayerProxyActivity.java
 create mode 100644 SW_VR/src/main/jniLibs/armeabi-v7a/libaudioplugingvrunity.so
 create mode 100644 SW_VR/src/main/jniLibs/armeabi-v7a/libgvrunity.so
 create mode 100755 SW_VR/src/main/jniLibs/armeabi-v7a/libmain.so
 create mode 100755 SW_VR/src/main/jniLibs/armeabi-v7a/libmono.so
 create mode 100755 SW_VR/src/main/jniLibs/armeabi-v7a/libunity.so
 create mode 100644 SW_VR/src/main/jniLibs/x86/libaudioplugingvrunity.so
 create mode 100644 SW_VR/src/main/jniLibs/x86/libgvrunity.so
 create mode 100755 SW_VR/src/main/jniLibs/x86/libmain.so
 create mode 100755 SW_VR/src/main/jniLibs/x86/libmono.so
 create mode 100755 SW_VR/src/main/jniLibs/x86/libunity.so
 create mode 100644 SW_VR/src/main/res/drawable-mdpi/app_icon.png
 create mode 100644 SW_VR/src/main/res/drawable-xhdpi/app_banner.png
 create mode 100644 SW_VR/src/main/res/values-v14/styles.xml
 create mode 100644 SW_VR/src/main/res/values-v21/styles.xml
 create mode 100644 SW_VR/src/main/res/values/strings.xml
 create mode 100644 SW_VR/src/main/res/values/styles.xml
