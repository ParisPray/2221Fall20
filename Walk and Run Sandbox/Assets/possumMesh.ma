//Maya ASCII 2019 scene
//Name: possumMesh.ma
//Last modified: Tue, Dec 08, 2020 11:42:45 AM
//Codeset: 1252
requires maya "2019";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2019";
fileInfo "version" "2019";
fileInfo "cutIdentifier" "201812112215-434d8d9c04";
fileInfo "osv" "Microsoft Windows 10 Technical Preview  (Build 18363)\n";
fileInfo "license" "student";
createNode transform -n "pCube1";
	rename -uid "97A8E7DC-43B6-98B0-25AC-719F245AE1BB";
	setAttr ".r" -type "double3" 90 0 0 ;
createNode mesh -n "pCubeShape1" -p "pCube1";
	rename -uid "D62EE9CB-4B83-29D5-CC1A-BCB581D3F71B";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
createNode polyExtrudeFace -n "polyExtrudeFace8";
	rename -uid "B7FB8430-453C-E69D-4CBF-E38B72DECBC9";
	setAttr ".ics" -type "componentList" 2 "f[0]" "f[59]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0.60134274378348151 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0.66349918 1.2889266 ;
	setAttr ".rs" 56975;
	setAttr ".lt" -type "double3" 0 -1.1102230246251565e-16 0.070129391229027727 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.077082045376300812 0.60134268417883674 1.2889266014099121 ;
	setAttr ".cbx" -type "double3" 0.077082045376300812 0.72565562143851081 1.2889266014099121 ;
createNode polyTweak -n "polyTweak8";
	rename -uid "CC5235E5-4C2F-4E85-BAFC-32BB74CFC5D4";
	setAttr ".uopa" yes;
	setAttr -s 34 ".tk";
	setAttr ".tk[0]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[1]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[6]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[7]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[20]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[22]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[23]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[24]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[45]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[46]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[61]" -type "float3" 0 0 0.097505145 ;
	setAttr ".tk[62]" -type "float3" 0 0 0.097505145 ;
	setAttr ".tk[66]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[67]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[68]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[79]" -type "float3" 0 0 0.097505145 ;
	setAttr ".tk[80]" -type "float3" 0 0 0.097505145 ;
	setAttr ".tk[87]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[88]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[89]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[93]" -type "float3" 0 0 0.097505145 ;
	setAttr ".tk[94]" -type "float3" 0 0 0.097505145 ;
	setAttr ".tk[120]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[121]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[123]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[124]" -type "float3" 0 -0.18081439 0 ;
	setAttr ".tk[126]" -type "float3" 0 0.13924818 0 ;
	setAttr ".tk[127]" -type "float3" 0 0.13924818 0 ;
	setAttr ".tk[128]" -type "float3" 0 0.13924818 0 ;
	setAttr ".tk[129]" -type "float3" 0 0.13924818 0 ;
	setAttr ".tk[130]" -type "float3" 0 0.13924818 0 ;
	setAttr ".tk[131]" -type "float3" 0 0.13924818 0 ;
	setAttr ".tk[132]" -type "float3" 0 0.13924818 0 ;
	setAttr ".tk[133]" -type "float3" 0 0.13924818 0 ;
createNode polyExtrudeFace -n "polyExtrudeFace7";
	rename -uid "EFB746D9-410B-F7AB-0902-0B9D925774D0";
	setAttr ".ics" -type "componentList" 2 "f[112]" "f[115]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0.60134274378348151 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 1.0147184 0.43884525 ;
	setAttr ".rs" 45297;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.5 0.92809415474463264 0.37769049406051636 ;
	setAttr ".cbx" -type "double3" 0.5 1.1013427139811591 0.5 ;
createNode polyTweak -n "polyTweak7";
	rename -uid "75730FD5-44D7-CB02-8B63-77BBFD2C572A";
	setAttr ".uopa" yes;
	setAttr -s 126 ".tk[0:125]" -type "float3"  0 -2.9802322e-08 0 0 -2.9802322e-08
		 0 0 -0.1732485 0 0 -0.1732485 0 0 -0.1732485 0 0 -0.1732485 0 0 -2.9802322e-08 0
		 0 -2.9802322e-08 0 0 1.4901161e-08 0 0 1.4901161e-08 0 0 -1.4901161e-08 0 0 -1.4901161e-08
		 0 0 0 0 0 0 0 0 -2.2351742e-08 0 0 -2.2351742e-08 0 0 7.4505806e-09 0 0 7.4505806e-09
		 0 0 -7.4505806e-09 0 0 -7.4505806e-09 0 0 2.2351742e-08 0 0 -0.1732485 0 0 0 0 0
		 0 0 0 0 0 0 0 0 0 -3.7252903e-08 0 0 -3.7252903e-08 0 0 0 0 0 0 0 0 0 0 0 0 0 -0.12006471
		 0 0 -0.089649901 0 0 -0.054200109 0 0 -0.02985118 0 0 0.02985118 0 0 0.054200109
		 0 0 0.089649901 0 0 0.12006471 0 0 0.12006471 0 0 0.12006471 3.7252903e-09 0 0.037405547
		 -3.7252903e-09 0 0.020022972 3.7252903e-09 0 -0.020022972 3.7252903e-09 0 -0.037405547
		 -3.7252903e-09 0 -0.12006471 3.7252903e-09 0 -0.12006471 0 0 0 -1.4901161e-08 0 0
		 -1.4901161e-08 0 0 -1.4901161e-08 0 0 -7.4505806e-09 0 0 0 0 0 -3.7252903e-09 0 0
		 1.8626451e-09 0 0 9.3132257e-10 0 0 -1.4901161e-08 0 0 -2.9802322e-08 0 0 -2.9802322e-08
		 0 0 0 0 0 -7.4505806e-09 0 0 -3.7252903e-09 0 0 0 0 0 3.7252903e-09 0 0 1.4901161e-08
		 0 0 -2.9802322e-08 0 0 -2.9802322e-08 0 0 -2.9802322e-08 0 0 -1.4901161e-08 0 0 -7.4505806e-09
		 0 0 0 0 -0.010011486 -3.7252903e-09 0 0 0 0 0 9.3132257e-10 0 0 -1.4901161e-08 0
		 0 2.9802322e-08 0 0 2.9802322e-08 0 0 0 0 0 -1.4901161e-08 0 0 -3.7252903e-09 0 -0.01492559
		 0 0 0 3.7252903e-09 0 0 1.4901161e-08 0 0 0 0 0.010011486 -3.7252903e-09 0 0 0 0
		 0 -7.4505806e-09 0 0 -1.4901161e-08 0 0 -2.9802322e-08 0 0 -2.9802322e-08 0 0 0 0
		 0 1.4901161e-08 0 0 3.7252903e-09 0 0.01492559 0 0 0 -3.7252903e-09 0 0 -1.4901161e-08
		 0 0 0 0 0 2.9802322e-08 0 0 2.9802322e-08 0 0 -1.4901161e-08 0 0 9.3132257e-10 0
		 0 0 0 0 -0.1732485 0 0 2.9802322e-08 0 0 -2.9802322e-08 0 0 2.9802322e-08 0 0 -0.1732485
		 0 0.12006471 0 0 0 -2.9802322e-08 0 0 -2.9802322e-08 0 0 -1.4901161e-08 0 0 -2.9802322e-08
		 0 0 -2.9802322e-08 0 -0.12006471 0 0 0 -0.17324848 0 0 2.9802322e-08 0 0 -2.9802322e-08
		 0 0 1.4901161e-08 0 0 -0.17324848 0 0.12006471 0 0 0 -2.9802322e-08 0 0 -2.9802322e-08
		 0 0 -1.4901161e-08 0 0 -2.9802322e-08 0 0 -2.9802322e-08 0 -0.12006471 0 0;
createNode polySplit -n "polySplit6";
	rename -uid "97DA7E4B-4CAE-5451-786B-ACA2A3983C57";
	setAttr -s 13 ".e[0:12]"  0.244619 0.75538099 0.75538099 0.244619 0.244619
		 0.244619 0.75538099 0.75538099 0.244619 0.244619 0.75538099 0.75538099 0.244619;
	setAttr -s 13 ".d[0:12]"  -2147483642 -2147483447 -2147483446 -2147483453 -2147483641 -2147483565 
		-2147483442 -2147483441 -2147483538 -2147483502 -2147483438 -2147483437 -2147483642;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit5";
	rename -uid "9DE0D7D7-4BED-FD97-C484-95B05E0E63A6";
	setAttr -s 13 ".e[0:12]"  0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5
		 0.5 0.5;
	setAttr -s 13 ".d[0:12]"  -2147483642 -2147483493 -2147483529 -2147483453 -2147483641 -2147483565 
		-2147483637 -2147483462 -2147483538 -2147483502 -2147483638 -2147483557 -2147483642;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit4";
	rename -uid "13DE8F50-42AA-D19A-8837-B1B63AFD4C46";
	setAttr -s 19 ".e[0:18]"  0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5
		 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5;
	setAttr -s 19 ".d[0:18]"  -2147483561 -2147483552 -2147483553 -2147483554 -2147483555 -2147483556 
		-2147483539 -2147483540 -2147483541 -2147483542 -2147483543 -2147483544 -2147483545 -2147483546 -2147483547 -2147483548 -2147483549 -2147483550 
		-2147483561;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit3";
	rename -uid "349E4265-4BBA-CE0E-6357-DB855E03604F";
	setAttr -s 19 ".e[0:18]"  0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5
		 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5;
	setAttr -s 19 ".d[0:18]"  -2147483648 -2147483645 -2147483606 -2147483598 -2147483590 -2147483551 
		-2147483594 -2147483602 -2147483610 -2147483646 -2147483647 -2147483630 -2147483622 -2147483614 -2147483569 -2147483618 -2147483626 -2147483634 
		-2147483648;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit2";
	rename -uid "D6782E31-4B78-4CA5-F0A1-83BEE76DA2B0";
	setAttr -s 19 ".e[0:18]"  0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5
		 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5;
	setAttr -s 19 ".d[0:18]"  -2147483648 -2147483645 -2147483606 -2147483598 -2147483590 -2147483561 
		-2147483594 -2147483602 -2147483610 -2147483646 -2147483647 -2147483630 -2147483622 -2147483614 -2147483569 -2147483618 -2147483626 -2147483634 
		-2147483648;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit1";
	rename -uid "660A6FFC-4B08-075B-969A-A68B9118B28A";
	setAttr -s 17 ".e[0:16]"  0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5
		 0.5 0.5 0.5 0.5 0.5 0.5;
	setAttr -s 17 ".d[0:16]"  -2147483644 -2147483629 -2147483621 -2147483613 -2147483616 -2147483624 
		-2147483632 -2147483643 -2147483639 -2147483608 -2147483600 -2147483592 -2147483589 -2147483597 -2147483605 -2147483640 -2147483644;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak6";
	rename -uid "83A84390-4E8E-0F31-9B4E-7791CE549A1E";
	setAttr ".uopa" yes;
	setAttr -s 5 ".tk";
	setAttr ".tk[28]" -type "float3" 0.072388321 -0.055616591 -1.2100518 ;
	setAttr ".tk[29]" -type "float3" -0.072388321 -0.055616591 -1.2100518 ;
	setAttr ".tk[30]" -type "float3" -0.072388321 0.055616587 -1.2100518 ;
	setAttr ".tk[31]" -type "float3" 0.072388321 0.055616587 -1.2100518 ;
createNode polyExtrudeFace -n "polyExtrudeFace6";
	rename -uid "19274896-4D58-E587-C9BD-51BA5AE93759";
	setAttr ".ics" -type "componentList" 1 "f[2]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0.60134274378348151 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0.49267727 -0.90653455 ;
	setAttr ".rs" 48955;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.15577241778373718 0.37299594893980781 -0.90653455257415771 ;
	setAttr ".cbx" -type "double3" 0.15577241778373718 0.61235860600996772 -0.90653455257415771 ;
createNode polyTweak -n "polyTweak5";
	rename -uid "C3B9438C-4F2F-6EA3-B3A7-4BAD050D458B";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk[24:27]" -type "float3"  0.34422758 -0.26447311 -0.1007
		 -0.34422758 -0.26447311 -0.1007 -0.34422758 0.26447311 -0.1007 0.34422758 0.26447311
		 -0.1007;
createNode polyExtrudeFace -n "polyExtrudeFace5";
	rename -uid "91348E1D-4830-D692-FA8D-F692C9304B92";
	setAttr ".ics" -type "componentList" 1 "f[2]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0.60134274378348151 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0.49267727 -0.80583453 ;
	setAttr ".rs" 33083;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.5 0.10852283850241462 -0.80583453178405762 ;
	setAttr ".cbx" -type "double3" 0.5 0.87683171644736091 -0.80583453178405762 ;
createNode polyTweak -n "polyTweak4";
	rename -uid "06A165D8-4B6F-04E0-6C26-0D8374CB9D7C";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk[20:23]" -type "float3"  0 -0.22451095 -0.3058345 0
		 -0.22451095 -0.3058345 0 0.0071800947 -0.3058345 0 0.0071800947 -0.3058345;
createNode polyExtrudeFace -n "polyExtrudeFace4";
	rename -uid "23AB6C6E-4CA3-6C40-27B9-E280087FC90F";
	setAttr ".ics" -type "componentList" 1 "f[2]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0.60134274378348151 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0.60134274 -0.5 ;
	setAttr ".rs" 40934;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.5 0.10134274378348151 -0.5 ;
	setAttr ".cbx" -type "double3" 0.5 1.1013426841788367 -0.5 ;
createNode polyTweak -n "polyTweak3";
	rename -uid "8FC41433-4649-4FDA-4CA0-63962F406B14";
	setAttr ".uopa" yes;
	setAttr -s 5 ".tk";
	setAttr ".tk[16]" -type "float3" 0.10139916 0.10139915 0 ;
	setAttr ".tk[17]" -type "float3" -0.10139916 0.10139915 0 ;
	setAttr ".tk[18]" -type "float3" -0.10139916 -0.10139915 0 ;
	setAttr ".tk[19]" -type "float3" 0.10139916 -0.10139915 0 ;
createNode polyExtrudeFace -n "polyExtrudeFace3";
	rename -uid "EBA4C341-49BB-EDC6-DF48-818303ABB366";
	setAttr ".ics" -type "componentList" 1 "f[0]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0.60134274378348151 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0.60134274 0.97867513 ;
	setAttr ".rs" 54158;
	setAttr ".lt" -type "double3" 0 0 0.21274642345832562 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.22571207582950592 0.3756306530528144 0.97867512702941895 ;
	setAttr ".cbx" -type "double3" 0.22571207582950592 0.82705477490950385 0.97867512702941895 ;
createNode polyTweak -n "polyTweak2";
	rename -uid "D535EB89-4641-2522-D930-B99F69E9CB72";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk[12:15]" -type "float3"  0.14762788 0.14762786 0 -0.14762788
		 0.14762786 0 -0.14762788 -0.14762786 0 0.14762788 -0.14762786 0;
createNode polyExtrudeFace -n "polyExtrudeFace2";
	rename -uid "982CF08F-4D63-27F9-A848-628C5ED087C9";
	setAttr ".ics" -type "componentList" 1 "f[0]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0.60134274378348151 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0.60134274 0.64213896 ;
	setAttr ".rs" 43475;
	setAttr ".lt" -type "double3" 0 0 0.33653610578544368 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.3733399510383606 0.22800279274512092 0.64213895797729492 ;
	setAttr ".cbx" -type "double3" 0.3733399510383606 0.97468263521719734 0.64213895797729492 ;
createNode polyTweak -n "polyTweak1";
	rename -uid "9B7D3348-4000-E050-8239-268B7A94BCC3";
	setAttr ".uopa" yes;
	setAttr -s 5 ".tk";
	setAttr ".tk[8]" -type "float3" 0.12666006 0.12666006 0.14213893 ;
	setAttr ".tk[9]" -type "float3" -0.12666006 0.12666006 0.14213893 ;
	setAttr ".tk[10]" -type "float3" -0.12666006 -0.12666006 0.14213893 ;
	setAttr ".tk[11]" -type "float3" 0.12666006 -0.12666006 0.14213893 ;
createNode polyExtrudeFace -n "polyExtrudeFace1";
	rename -uid "CC351EC4-4FDD-19A0-A089-DEBAAA3F70C6";
	setAttr ".ics" -type "componentList" 1 "f[0]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0.60134274378348151 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0.60134274 0.5 ;
	setAttr ".rs" 49006;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.5 0.10134274378348151 0.5 ;
	setAttr ".cbx" -type "double3" 0.5 1.1013427437834815 0.5 ;
createNode polyCube -n "polyCube1";
	rename -uid "DA8CE6F0-4740-E975-A8AD-BC86F8676C21";
	setAttr ".cuv" 4;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 4 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
connectAttr "polyExtrudeFace8.out" "pCubeShape1.i";
connectAttr "polyTweak8.out" "polyExtrudeFace8.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace8.mp";
connectAttr "polyExtrudeFace7.out" "polyTweak8.ip";
connectAttr "polyTweak7.out" "polyExtrudeFace7.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace7.mp";
connectAttr "polySplit6.out" "polyTweak7.ip";
connectAttr "polySplit5.out" "polySplit6.ip";
connectAttr "polySplit4.out" "polySplit5.ip";
connectAttr "polySplit3.out" "polySplit4.ip";
connectAttr "polySplit2.out" "polySplit3.ip";
connectAttr "polySplit1.out" "polySplit2.ip";
connectAttr "polyTweak6.out" "polySplit1.ip";
connectAttr "polyExtrudeFace6.out" "polyTweak6.ip";
connectAttr "polyTweak5.out" "polyExtrudeFace6.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace6.mp";
connectAttr "polyExtrudeFace5.out" "polyTweak5.ip";
connectAttr "polyTweak4.out" "polyExtrudeFace5.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace5.mp";
connectAttr "polyExtrudeFace4.out" "polyTweak4.ip";
connectAttr "polyTweak3.out" "polyExtrudeFace4.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace4.mp";
connectAttr "polyExtrudeFace3.out" "polyTweak3.ip";
connectAttr "polyTweak2.out" "polyExtrudeFace3.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace3.mp";
connectAttr "polyExtrudeFace2.out" "polyTweak2.ip";
connectAttr "polyTweak1.out" "polyExtrudeFace2.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace2.mp";
connectAttr "polyExtrudeFace1.out" "polyTweak1.ip";
connectAttr "polyCube1.out" "polyExtrudeFace1.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace1.mp";
connectAttr "pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
// End of possumMesh.ma
