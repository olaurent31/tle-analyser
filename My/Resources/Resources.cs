// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.My.Resources.Resources
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TLE_Analyser.My.Resources
{
  /// <summary>
  ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
  /// </summary>
  [CompilerGenerated]
  [StandardModule]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [HideModuleName]
  [DebuggerNonUserCode]
  public sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    /// <summary>
    ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) TLE_Analyser.My.Resources.Resources.resourceMan, (object) null))
          TLE_Analyser.My.Resources.Resources.resourceMan = new ResourceManager("TLE_Analyser.Resources", typeof (TLE_Analyser.My.Resources.Resources).Assembly);
        return TLE_Analyser.My.Resources.Resources.resourceMan;
      }
    }

    /// <summary>
    ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
    ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static CultureInfo Culture
    {
      get => TLE_Analyser.My.Resources.Resources.resourceCulture;
      set => TLE_Analyser.My.Resources.Resources.resourceCulture = value;
    }

    /// <summary>Recherche une chaîne localisée semblable à Astropedia (c) 2005-2011.</summary>
    public static string affichage => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (affichage), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à jours.</summary>
    public static string age_tle1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (age_tle1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Les éléments orbitaux sont plus vieux que # jour(s). Souhaitez-vous les mettre à jour?.
    /// </summary>
    public static string age_tle2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (age_tle2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à OSCAR 7 (AO-7)
    /// 1 07530U 74089B   14018.52342073 -.00000016  00000-0  17161-3 0  8742
    /// 2 07530 101.4562   5.3838 0011665 226.2675 292.1349 12.53601347792765
    /// PHASE 3B (AO-10)
    /// 1 14129U 83058B   14018.18669058  .00000246  00000-0  00000+0 0  1474
    /// 2 14129  26.4866 238.8000 5984072 325.1760 176.8855  2.05866399202160
    /// UOSAT 2 (UO-11)
    /// 1 14781U 84021B   14018.42408739  .00000591  00000-0  82536-4 0  3927
    /// 2 14781  97.8739  81.3414 0007520 313.0667  46.9916 14.81243959605795
    /// PACSAT ( [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string amateur => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (amateur), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à À propos de #.</summary>
    public static string apropos1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (apropos1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Version #    (26 octobre 2011).</summary>
    public static string apropos2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (apropos2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à PreviSat est un logiciel de calcul de la position des satellites artificiels.&amp;Il permet d'afficher la position des satellites à tout instant (en temps réel ou en mode manuel), d'effectuer les prévisions de passage pour n'importe quel lieu d'observation, et également de déterminer très rapidement les flashs Iridium.&amp;&amp;PreviSat est entièrement gratuit!.
    /// </summary>
    public static string apropos3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (apropos3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à BEIDOU 2A
    /// 1 31115U 07011A   14018.09743000 -.00000064  00000-0  00000+0 0   875
    /// 2 31115  53.4668   7.9485 0003177 259.4647 100.5039  1.77348088 46007
    /// BEIDOU G1
    /// 1 36287U 10001A   14017.93752383 -.00000284  00000-0  10000-3 0  1532
    /// 2 36287   1.5833   1.4552 0003209 220.3057  12.9383  1.00267572 14717
    /// BEIDOU G3
    /// 1 36590U 10024A   14019.01108381 -.00000353  00000-0  10000-3 0    28
    /// 2 36590   1.7328  34.8630 0003331 298.7564 259.2349  1.00269201 13336
    /// BEIDOU I [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string beidou => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (beidou), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à /**
    ///  * @author mrdoob / http://mrdoob.com/
    ///  */
    /// 
    /// THREE.SpriteCanvasMaterial = function ( parameters ) {
    /// 
    /// 	THREE.Material.call( this );
    /// 
    /// 	this.type = 'SpriteCanvasMaterial';
    /// 
    /// 	this.color = new THREE.Color( 0xffffff );
    /// 	this.program = function ( context, color ) {};
    /// 
    /// 	this.setValues( parameters );
    /// 
    /// };
    /// 
    /// THREE.SpriteCanvasMaterial.prototype = Object.create( THREE.Material.prototype );
    /// THREE.SpriteCanvasMaterial.prototype.constructor = THREE.SpriteCanvasMaterial;
    /// 
    /// THREE.SpriteCanvasMaterial.prototype.clone = func [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string CanvasRenderer => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (CanvasRenderer), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à &amp;Ciel.</summary>
    public static string carte1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (carte1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à &amp;Carte.</summary>
    public static string carte2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (carte2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Jour.</summary>
    public static string conditions_observation1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions_observation1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Crépuscule civil.</summary>
    public static string conditions_observation2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions_observation2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Crépuscule nautique.</summary>
    public static string conditions_observation3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions_observation3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Crépuscule astronomique.</summary>
    public static string conditions_observation4 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions_observation4), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Nuit.</summary>
    public static string conditions_observation5 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions_observation5), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Age du TLE                : # jours (au #).
    /// </summary>
    public static string conditions1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Age du TLE le plus récent : # jours (au #)&amp;Age du TLE le plus ancien : # jours.
    /// </summary>
    public static string conditions2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Lieu d'observation        : #     #°#'#" #   #°#'#" #   #.
    /// </summary>
    public static string conditions3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Fuseau horaire            : # # #.
    /// </summary>
    public static string conditions4 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions4), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Conditions d'observations : Hauteur minimale du satellite = #°.
    /// </summary>
    public static string conditions5 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions5), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Conditions d'observations : Hauteur maximale du Soleil = #°.
    /// </summary>
    public static string conditions6 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions6), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Hauteur minimale du satellite = #°.
    /// </summary>
    public static string conditions7 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions7), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Unité de distance         : #.</summary>
    public static string conditions8 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (conditions8), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Est.</summary>
    public static string coord_geo1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (coord_geo1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Ouest.</summary>
    public static string coord_geo2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (coord_geo2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Nord.</summary>
    public static string coord_geo3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (coord_geo3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Sud.</summary>
    public static string coord_geo4 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (coord_geo4), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Longitude :.</summary>
    public static string coord_geo5 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (coord_geo5), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Latitude :.</summary>
    public static string coord_geo6 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (coord_geo6), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Hauteur :.</summary>
    public static string coord_geo7 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (coord_geo7), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Azimut :.</summary>
    public static string coord_geo8 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (coord_geo8), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à /**
    ///  * @author alteredq / http://alteredqualia.com/
    ///  *
    ///  * Full-screen textured quad shader
    ///  */
    /// 
    /// THREE.CopyShader = {
    /// 
    /// 	uniforms: {
    /// 
    /// 		"tDiffuse": { type: "t", value: null },
    /// 		"opacity":  { type: "f", value: 1.0 }
    /// 
    /// 	},
    /// 
    /// 	vertexShader: [
    /// 
    /// 		"varying vec2 vUv;",
    /// 
    /// 		"void main() {",
    /// 
    /// 			"vUv = uv;",
    /// 			"gl_Position = projectionMatrix * modelViewMatrix * vec4( position, 1.0 );",
    /// 
    /// 		"}"
    /// 
    /// 	].join("\n"),
    /// 
    /// 	fragmentShader: [
    /// 
    /// 		"uniform float opacity;",
    /// 
    /// 		"uniform sampler2D tDiffuse;",
    /// 
    /// 		"varying vec2 vUv;",
    /// 
    /// 		" [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string CopyShader => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (CopyShader), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à CUTE-1 (CO-55)
    /// 1 27844U 03031E   14018.83115527  .00000253  00000-0  13581-3 0  8358
    /// 2 27844  98.7006  29.7598 0009242 352.8643  58.2800 14.21365223547362
    /// CUBESAT XI-IV (CO-57)
    /// 1 27848U 03031J   14018.53509354  .00000198  00000-0  11154-3 0  7760
    /// 2 27848  98.7098  29.0967 0009301   0.4149 115.7399 14.21071193547242
    /// CUBESAT XI-V (CO-58)
    /// 1 28895U 05043F   14019.11808477  .00000666  00000-0  14279-3 0  6749
    /// 2 28895  97.8467 228.6413 0018745 119.7920 240.5149 14.61500503438471
    /// CAPE1    [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string cubesat => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (cubesat), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à /**
    ///  * @author alteredq / http://alteredqualia.com/
    ///  * @author mr.doob / http://mrdoob.com/
    ///  */
    /// 
    /// var Detector = {
    /// 
    /// 	canvas: !! window.CanvasRenderingContext2D,
    /// 	webgl: ( function () { try { var canvas = document.createElement( 'canvas' ); return !! ( window.WebGLRenderingContext &amp;&amp; ( canvas.getContext( 'webgl' ) || canvas.getContext( 'experimental-webgl' ) ) ); } catch ( e ) { return false; } } )(),
    /// 	workers: !! window.Worker,
    /// 	fileapi: window.File &amp;&amp; window.FileReader &amp;&amp; window.FileList &amp;&amp; window.Blob,
    /// 
    /// 	g [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string Detector => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (Detector), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Sphérique. R=.</summary>
    public static string dimension_sat1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (dimension_sat1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Cylindrique. L=.</summary>
    public static string dimension_sat2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (dimension_sat2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à , R=.</summary>
    public static string dimension_sat3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (dimension_sat3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Boîte..</summary>
    public static string dimension_sat4 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (dimension_sat4), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Inconnues.</summary>
    public static string dimension_sat5 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (dimension_sat5), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Ascendant.</summary>
    public static string direction1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (direction1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Descendant.</summary>
    public static string direction2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (direction2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à BEIJING 1
    /// 1 28890U 05043A   14019.22695364  .00000193  00000-0  48503-4 0  3150
    /// 2 28890  97.8301 225.9295 0016787 115.2142 245.0780 14.60603915438653
    /// HJ-1A
    /// 1 33320U 08041A   14019.17301587  .00000704  00000-0  11070-3 0  8971
    /// 2 33320  97.7912  79.6408 0028395  73.6209 286.8137 14.75228226289111
    /// HJ-1B
    /// 1 33321U 08041B   14019.20651929  .00001045  00000-0  15985-3 0  9524
    /// 2 33321  97.7943  80.0959 0038191  88.8528 271.7061 14.75267946289100
    /// YAOGAN 4 [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string dmc => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (dmc), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap earth_atmos_2048 => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (earth_atmos_2048), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap earth_clouds_1024 => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (earth_clouds_1024), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap earth_normal_2048 => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (earth_normal_2048), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap earth_specular_2048 => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (earth_specular_2048), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap EarthMap => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (EarthMap), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap EarthMap2 => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (EarthMap2), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>Recherche une chaîne localisée semblable à UTC.</summary>
    public static string echelle_temps => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (echelle_temps), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à SAUDISAT 1C
    /// 1 27607U 02058C   14018.32044132  .00000745  00000-0  13476-3 0  2779
    /// 2 27607  64.5584 329.0415 0033124  69.1167   9.3510 14.73344445595403
    /// SAUDISAT 2
    /// 1 28371U 04025F   14019.21827844  .00000232  00000-0  65602-4 0  6833
    /// 2 28371  97.9628   5.6306 0024704 239.2582 120.6183 14.53558178506922
    /// UNISAT 3
    /// 1 28373U 04025H   14018.50453649  .00000547  00000-0  16653-3 0  7239
    /// 2 28373  98.1851 338.0176 0070676  36.8847 100.1588 14.44349028504008
    /// SAUDISAT [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string education => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (education), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à /**
    ///  * @author alteredq / http://alteredqualia.com/
    ///  */
    /// 
    /// THREE.EffectComposer = function ( renderer, renderTarget ) {
    /// 
    /// 	this.renderer = renderer;
    /// 
    /// 	if ( renderTarget === undefined ) {
    /// 
    /// 		var pixelRatio = renderer.getPixelRatio();
    /// 
    /// 		var width  = Math.floor( renderer.context.canvas.width  / pixelRatio ) || 1;
    /// 		var height = Math.floor( renderer.context.canvas.height / pixelRatio ) || 1;
    /// 		var parameters = { minFilter: THREE.LinearFilter, magFilter: THREE.LinearFilter, format: THREE.RGBFormat, stencilBuffer:  [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string EffectComposer => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (EffectComposer), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à PROBA-1
    /// 1 26958U 01049B   14019.08418887  .00000592  00000-0  60265-4 0  7923
    /// 2 26958  97.4452  27.2404 0077531 180.4614 179.6542 14.92119131665619
    /// BIRD 2
    /// 1 26959U 01049C   14019.23271412  .00003978  00000-0  17974-3 0  5794
    /// 2 26959  97.8343 253.4768 0014781  76.5767  38.2900 15.21492435676075
    /// CUTE-1 (CO-55)
    /// 1 27844U 03031E   14018.83115527  .00000253  00000-0  13581-3 0  8358
    /// 2 27844  98.7006  29.7598 0009242 352.8643  58.2800 14.21365223547362
    /// CUBESAT  [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string engineering => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (engineering), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à EVENEMENTS.</summary>
    public static string evenements01 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements01), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Évènements orbitaux.</summary>
    public static string evenements02 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements02), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Noeud Ascendant - PSO = 0°.</summary>
    public static string evenements03 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements03), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Noeud Descendant - PSO = 180°.</summary>
    public static string evenements04 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements04), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Pénombre -&gt; Ombre.</summary>
    public static string evenements05 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements05), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Ombre -&gt; Pénombre.</summary>
    public static string evenements06 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements06), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Pénombre -&gt; Lumière.</summary>
    public static string evenements07 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements07), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Lumière -&gt; Pénombre.</summary>
    public static string evenements08 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements08), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Périgée :.</summary>
    public static string evenements09 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements09), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Apogée :.</summary>
    public static string evenements10 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements10), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Transition jour -&gt; nuit.</summary>
    public static string evenements11 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements11), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Transition nuit -&gt; jour.</summary>
    public static string evenements12 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements12), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Passage à PSO =.</summary>
    public static string evenements13 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements13), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à    Date     Heure      PSO    Longitude  Latitude  Évènements.
    /// </summary>
    public static string evenements14 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements14), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Temps écoulé : # #.</summary>
    public static string evenements15 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (evenements15), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Fichier d'aide de.</summary>
    public static string fichier_aide => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (fichier_aide), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à /**
    ///  * @author alteredq / http://alteredqualia.com/
    ///  */
    /// 
    /// THREE.FilmPass = function ( noiseIntensity, scanlinesIntensity, scanlinesCount, grayscale ) {
    /// 
    /// 	if ( THREE.FilmShader === undefined )
    /// 		console.error( "THREE.FilmPass relies on THREE.FilmShader" );
    /// 
    /// 	var shader = THREE.FilmShader;
    /// 
    /// 	this.uniforms = THREE.UniformsUtils.clone( shader.uniforms );
    /// 
    /// 	this.material = new THREE.ShaderMaterial( {
    /// 
    /// 		uniforms: this.uniforms,
    /// 		vertexShader: shader.vertexShader,
    /// 		fragmentShader: shader.fragmentShader
    /// 
    /// 	} );
    /// 
    /// 	 [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string FilmPass => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (FilmPass), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à /**
    ///  * @author alteredq / http://alteredqualia.com/
    ///  *
    ///  * Film grain &amp; scanlines shader
    ///  *
    ///  * - ported from HLSL to WebGL / GLSL
    ///  * http://www.truevision3d.com/forums/showcase/staticnoise_colorblackwhite_scanline_shaders-t18698.0.html
    ///  *
    ///  * Screen Space Static Postprocessor
    ///  *
    ///  * Produces an analogue noise overlay similar to a film grain / TV static
    ///  *
    ///  * Original implementation and noise algorithm
    ///  * Pat 'Hawthorne' Shearon
    ///  *
    ///  * Optimized scanlines + noise version with intensity scaling
    ///  * Georg 'Leviatha [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string FilmShader => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (FilmShader), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Fichiers JPEG|*.jpg|Fichiers BMP|*.bmp|Tous les fichiers|*.*.
    /// </summary>
    public static string filtre1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (filtre1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Fichiers texte|*.txt|Fichiers TLE|*.tle|Tous les fichiers|*.*.
    /// </summary>
    public static string filtre2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (filtre2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Fichiers texte|*.txt|Fichiers TLE|*.tle|Fichiers gz|*.gz|Tous les fichiers|*.*.
    /// </summary>
    public static string filtre3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (filtre3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Fichiers texte|*.txt|Tous les fichiers|*.*.
    /// </summary>
    public static string filtre4 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (filtre4), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à /**
    ///  * @author James Baicoianu / http://www.baicoianu.com/
    ///  */
    /// 
    /// THREE.FlyControls = function ( object, domElement ) {
    /// 
    /// 	this.object = object;
    /// 
    /// 	this.domElement = ( domElement !== undefined ) ? domElement : document;
    /// 	if ( domElement ) this.domElement.setAttribute( 'tabindex', -1 );
    /// 
    /// 	// API
    /// 
    /// 	this.movementSpeed = 1.0;
    /// 	this.rollSpeed = 0.005;
    /// 
    /// 	this.dragToLook = false;
    /// 	this.autoForward = false;
    /// 
    /// 	// disable default target object behavior
    /// 
    /// 	// internals
    /// 
    /// 	this.tmpQuaternion = new THREE.Quaternion();
    /// 
    /// 	this. [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string FlyControls => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (FlyControls), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à GALILEO-PFM (PRN E11)
    /// 1 37846U 11060A   14018.83566919 -.00000012  00000-0  00000+0 0  3208
    /// 2 37846  55.0000 106.7487 0003430 272.5537  51.8644  1.70474074 13976
    /// GALILEO-FM2 (PRN E12)
    /// 1 37847U 11060B   14018.41059301 -.00000014  00000-0  00000+0 0  3263
    /// 2 37847  55.0005 106.7594 0004907 265.0270 199.2509  1.70474328 13971
    /// GALILEO-FM3 (PRN E19)
    /// 1 38857U 12055A   14016.00529000  .00000066  00000-0  00000+0 0  1861
    /// 2 38857  55.1384 226.7192 0000905 167.5068 192.5640  1.70473612  7853
    /// GALILEO- [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string galileo => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (galileo), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à GOES 3
    /// 1 10953U 78062A   14018.52436319 -.00000130  00000-0  00000+0 0  4964
    /// 2 10953  14.4416 344.6299 0004413 114.3867 106.1806  1.00272577 83474
    /// TDRS 3
    /// 1 19548U 88091B   14017.31546959 -.00000295  00000-0  10000-3 0  2138
    /// 2 19548  14.3436  21.5320 0015537 331.0824 188.7051  1.00267760 79932
    /// LEASAT 5
    /// 1 20410U 90002B   14016.03187631 -.00000076  00000-0  10000-3 0   639
    /// 2 20410  10.7823  22.6532 0002144 220.0866 316.1547  1.00274144 73229
    /// SKYNET 4 [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string geo => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (geo), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à LAGEOS 1
    /// 1 08820U 76039A   14019.17760774  .00000021  00000-0  00000+0 0  5715
    /// 2 08820 109.8486  66.9026 0044805 193.6254 186.3028  6.38664736624139
    /// AJISAI (EGS)
    /// 1 16908U 86061A   14018.70003627 -.00000106  00000-0 -63255-4 0  3138
    /// 2 16908  50.0103  44.1987 0011384 164.2170 304.9793 12.44475109916352
    /// LAGEOS 2
    /// 1 22195U 92070B   14017.37340220 -.00000009  00000-0  00000+0 0  8012
    /// 2 22195  52.6463 252.1158 0137751   5.3723 225.7130  6.47294360502115
    /// STELLA   [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string geodetic => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (geodetic), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à COSMOS 2413 (712)
    /// 1 28509U 04053B   14018.35626178  .00000070  00000-0  10000-3 0  5300
    /// 2 28509  63.1899 221.5086 0005676 139.0633 328.1275  2.13100549 70533
    /// COSMOS 2419 (714)
    /// 1 28915U 05050A   14018.65354150  .00000010  00000-0  00000+0 0  2913
    /// 2 28915  65.0049 107.8883 0015467 349.1863 332.7360  2.13110252 62787
    /// COSMOS 2425 (716)
    /// 1 29670U 06062A   14018.22809318 -.00000051  00000-0  10000-3 0  9929
    /// 2 29670  65.8881 346.6842 0023091 340.6070  88.0335  2.13104995 54987
    /// COSMOS 2 [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string glo_ops => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (glo_ops), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à GLOBALSTAR M001 [-]
    /// 1 25162U 98008A   14018.86103616 -.00000069  00000-0  20937-3 0  6353
    /// 2 25162  52.0005 220.4504 0002690 100.1157   0.9288 12.38041966727619
    /// GLOBALSTAR M004 [B]
    /// 1 25163U 98008B   14017.98274154 -.00000062  00000-0  23249-3 0  7265
    /// 2 25163  51.9986 168.1315 0004060  65.4147  91.7121 12.63210707734968
    /// GLOBALSTAR M002 [-]
    /// 1 25164U 98008C   14018.81127451 -.00000070  00000-0  12708-3 0  6149
    /// 2 25164  51.9988 248.5486 0001983  84.2232 355.5526 11.61443071699899
    /// GLOBALST [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string globalstar => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (globalstar), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à COSMOS 2425 (716)
    /// 1 29670C 06062A   14015.99981482 -.00000002  00000-0  00000-0 0   151
    /// 2 29670  65.8892 346.7583 0023409 341.7529 177.4175  2.13105260    12
    /// COSMOS 2426 (717)
    /// 1 29671C 06062B   14015.99981482 -.00000002  00000-0  00000-0 0   152
    /// 2 29671  65.9057 346.8210 0015513 172.8260 213.6048  2.13103277    15
    /// COSMOS 2424 (715)
    /// 1 29672C 06062C   14015.99981482 -.00000002  00000-0  00000-0 0   153
    /// 2 29672  65.8909 346.7657 0014850 171.7359  33.5848  2.13102340    12
    /// COSMOS 2 [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string glonass => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (glonass), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap gmico1 => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (gmico1), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap gmico2 => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (gmico2), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>
    ///   Recherche une chaîne localisée semblable à GOES 1 [-]
    /// 1 08366U 75100A   14018.52468860 -.00000053  00000-0  00000+0 0  6624
    /// 2 08366  13.5608 332.5012 0002730 191.2296  28.9559  1.00314531139757
    /// GOES 2 [-]
    /// 1 10061U 77048A   14018.99685493 -.00000054  00000-0  00000+0 0  9248
    /// 2 10061  14.4551 341.0743 0012778 285.3948 227.0419  0.99399496 78464
    /// GOES 3 [P]
    /// 1 10953U 78062A   14018.52436319 -.00000130  00000-0  00000+0 0  4964
    /// 2 10953  14.4416 344.6299 0004413 114.3867 106.1806  1.00272577 83474
    /// GOES 4 [ [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string goes => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (goes), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à &lt;!DOCTYPE html&gt;
    /// &lt;html&gt;
    ///   &lt;head&gt;
    ///     &lt;script src="http://www.google.com/jsapi"&gt;&lt;/script&gt;
    ///     &lt;script type="text/javascript"&gt;
    ///       google.load("earth", "1");
    /// 
    ///       //VARIABLES//////////////////////////////////////////////
    /// 
    ///       var ge = null;
    ///       var placemark;
    ///       var lineStringToEarth;
    ///       var lineStringToStation;
    ///       var multGeoPlacemark;
    ///       var geoms;
    ///       var nodeItem;
    /// 
    ///       //INITIALISATION/////////////////////////////////////////
    /// 
    ///       function init() {
    ///       google [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string GoogleEarth => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (GoogleEarth), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à GORIZONT 1 [-]
    /// 1 11158U 78118A   14017.41268366 -.00000037  00000-0  00000+0 0  8720
    /// 2 11158  19.0841 292.2867 3310647 142.9220 245.3641  1.00257492 77471
    /// GORIZONT 2 [-]
    /// 1 11440U 79062A   14018.05498794  .00000018  00000-0  00000+0 0  1578
    /// 2 11440  14.1846 337.5332 0003941 185.7012  35.8054  1.00255126 92551
    /// GORIZONT 3 [-]
    /// 1 11648U 79105A   14017.93858704 -.00000353  00000-0  00000+0 0   227
    /// 2 11648  14.2469 338.6776 0015907 132.3517  92.1483  1.00295098 77029
    /// GORIZONT [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string gorizont => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (gorizont), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à GPS BIIA-10 (PRN 32)
    /// 1 20959C 90103A   14020.70648148  .00000000  00000-0  00000-0 0   208
    /// 2 20959  54.3291 215.0235 0115845 347.6742 306.9164  2.00581888    16
    /// GPS BIIA-14 (PRN 26)
    /// 1 22014C 92039A   14020.70648148  .00000000  00000-0  00000-0 0   202
    /// 2 22014  55.9419 275.6500 0211477  72.0087   4.7716  2.00562807    11
    /// GPS BIIA-21 (PRN 09)
    /// 1 22700C 93042A   14020.70648148  .00000000  00000-0  00000-0 0   209
    /// 2 22700  56.3166 330.2068 0166446 100.9980 338.7060  2.00561554    12
    /// GPS BIIA [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string gps => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (gps), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à GPS BIIA-10 (PRN 32)
    /// 1 20959U 90103A   14017.80552048  .00000056  00000-0  00000+0 0  2424
    /// 2 20959  54.3308 215.1402 0115719 347.6039  12.1468  2.00581822169513
    /// GPS BIIA-14 (PRN 26)
    /// 1 22014U 92039A   14018.24767538 -.00000007  00000-0  00000+0 0   255
    /// 2 22014  55.9416 275.7470 0211643  71.9325  29.4792  2.00562598151240
    /// GPS BIIA-21 (PRN 09)
    /// 1 22700U 93042A   14018.39355464 -.00000071  00000-0  00000+0 0  2779
    /// 2 22700  56.3175 330.2978 0166527 100.9379 108.7441  2.00561355150590
    /// GPS BIIA [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string gps_ops => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (gps_ops), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap GroundStation => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (GroundStation), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Carpenterville;CAR;40.644;-75.191;69.4
    /// Hartebeeshoek;HBK;-25.885;27.707;1555.59
    /// Kumsan;KUM;37.12;127.48;181.2
    /// Mountainside;MTS;39.6;-77.76;187
    /// Redu;REDU;50.003;5.145;332
    /// Malindi;MAL;-3;40.32;7
    /// Carnavon;CAR;-24;113;0.0
    /// Santiago;AGO;-33.15139;-70.668402;705
    /// Kourou;KRU;5.250501;-52.804627;9
    /// Santa Maria;SMA;36.997047;-25.136003;200
    /// Maspalomas;MSP;27.762914;-15.633806;150
    /// Kiruna;KIR;67.857157;20.964274;360
    /// Perth;PER;-31.804224;115.884705;44
    /// Villafranca;VIL;40.442587;-3.951591;600
    /// Svalbard;SG;78.229 [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string GroundStations => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (GroundStations), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Looks up a localized resource of type System.Byte[].</summary>
    public static byte[] ICSharpCode_SharpZipLib => (byte[]) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (ICSharpCode_SharpZipLib), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>Recherche une chaîne localisée semblable à Satellite non visible (Ombre).</summary>
    public static string illumination_sat1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (illumination_sat1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Illumination :.</summary>
    public static string illumination_sat2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (illumination_sat2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à  (Pénombre).</summary>
    public static string illumination_sat3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (illumination_sat3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Magnitude : Non Visible (Ombre).</summary>
    public static string illumination_sat4 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (illumination_sat4), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Magnitude (Illumination) :.</summary>
    public static string illumination_sat5 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (illumination_sat5), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Satellite non visible.</summary>
    public static string illumination_sat6 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (illumination_sat6), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à  : Pénombre.</summary>
    public static string illumination_sat7 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (illumination_sat7), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à LEASAT 5
    /// 1 20410U 90002B   14016.03187631 -.00000076  00000-0  10000-3 0   639
    /// 2 20410  10.7823  22.6532 0002144 220.0866 316.1547  1.00274144 73229
    /// INTELSAT 603 (IS-603)
    /// 1 20523U 90021A   14018.04961868 -.00000235  00000-0  10000-3 0  4361
    /// 2 20523   9.9603  47.1797 0003638 165.5669 201.8315  1.00272445 80276
    /// INTELSAT 701 (IS-701)
    /// 1 22871U 93066A   14018.40625788 -.00000214  00000-0  10000-3 0  3297
    /// 2 22871   1.7483  74.5520 0004854 242.5500 277.3554  1.00271726 74018
    /// INTELSAT [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string intelsat => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (intelsat), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à IRIDIUM 8 [+]
    /// 1 24792U 97020A   14018.38013764  .00000044  00000-0  87949-5 0  6737
    /// 2 24792  86.3992 119.4628 0002108 117.4193 242.7217 14.34209923874631
    /// IRIDIUM 7 [+]
    /// 1 24793U 97020B   14018.53131302  .00000496  00000-0  16990-3 0  6674
    /// 2 24793  86.3997 119.6138 0002153 114.3270 338.4595 14.34213211874656
    /// IRIDIUM 6 [+]
    /// 1 24794U 97020C   14018.36744494  .00000420  00000-0  14286-3 0  4668
    /// 2 24794  86.3994 119.6400 0002285 115.5824 244.5608 14.34213054874635
    /// IRIDIUM  [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string iridium => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (iridium), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à IRIDIUM.</summary>
    public static string iridium1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (iridium1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à TLE.</summary>
    public static string iridium2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (iridium2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à ADG.</summary>
    public static string iridium3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (iridium3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Ir     Date      Heure    Azimut Sat Hauteur Sat  AD Sat    Decl Sat  Cst Ang  Mir Magn   Alt   Dist  Az Soleil  Haut Soleil.
    /// </summary>
    public static string iridium4 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (iridium4), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à mes préférés.</summary>
    public static string lieux_observation1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (lieux_observation1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Ajouter à Mes préférés.</summary>
    public static string lieux_observation2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (lieux_observation2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Le lieu d'observation "#" a été ajouté dans la catégorie "Mes préférés".
    /// </summary>
    public static string lieux_observation3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (lieux_observation3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Voulez-vous vraiment supprimer "#" de la catégorie "#"?.
    /// </summary>
    public static string lieux_observation4 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (lieux_observation4), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Le lieu d'observation "#" a été supprimé de la catégorie "#".
    /// </summary>
    public static string lieux_observation5 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (lieux_observation5), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Mes Préférés.</summary>
    public static string lieux_observation6 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (lieux_observation6), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à * Défaut.</summary>
    public static string lieux_observation7 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (lieux_observation7), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à /**
    ///  * @author alteredq / http://alteredqualia.com/
    ///  */
    /// 
    /// THREE.MaskPass = function ( scene, camera ) {
    /// 
    /// 	this.scene = scene;
    /// 	this.camera = camera;
    /// 
    /// 	this.enabled = true;
    /// 	this.clear = true;
    /// 	this.needsSwap = false;
    /// 
    /// 	this.inverse = false;
    /// 
    /// };
    /// 
    /// THREE.MaskPass.prototype = {
    /// 
    /// 	render: function ( renderer, writeBuffer, readBuffer, delta ) {
    /// 
    /// 		var context = renderer.context;
    /// 
    /// 		// don't update color or depth
    /// 
    /// 		context.colorMask( false, false, false, false );
    /// 		context.depthMask( false );
    /// 
    /// 		// set up stencil
    ///  [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string MaskPass => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (MaskPass), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à &amp;Agrandir.</summary>
    public static string maximise1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (maximise1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à &amp;Réduire.</summary>
    public static string maximise2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (maximise2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à POSITION : Le fichier # n'existe pas, veuillez réinstaller PreviSat.
    /// </summary>
    public static string mess01 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess01), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à POSITION : Erreur rencontrée lors de l'initialisation&amp;Le répertoire contenant les fichiers de lieux d'observation n'existe pas
    /// .
    /// </summary>
    public static string mess02 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess02), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à POSITION : Erreur rencontrée lors de l'initialisation&amp;Il n'existe aucun fichier de lieux d'observation.
    /// </summary>
    public static string mess03 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess03), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à POSITION : Erreur rencontrée lors de l'exécution&amp;La position du satellite # (numéro NORAD : #) ne peut pas être calculée (altitude négative).
    /// </summary>
    public static string mess04 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess04), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à POSITION : Le fichier # ne contient aucun satellite ou n'est pas valide.
    /// </summary>
    public static string mess05 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess05), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à POSITION : La longueur des lignes du TLE du satellite # (numéro NORAD : #) est incorrecte.
    /// </summary>
    public static string mess06 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess06), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à POSITION : Les numéros de ligne du TLE du satellite # (numéro NORAD : # ) sont incorrects.
    /// </summary>
    public static string mess07 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess07), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à POSITION : Erreur position des espaces du TLE :&amp;Satellite # - numéro NORAD : #.
    /// </summary>
    public static string mess08 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess08), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à POSITION : Erreur Ponctuation du TLE :&amp;Satellite # - numéro NORAD : #.
    /// </summary>
    public static string mess09 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess09), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à POSITION : Les deux lignes du TLE du satellite # ont des numéros NORAD différents (# et #).
    /// </summary>
    public static string mess10 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess10), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à POSITION : Erreur CheckSum ligne # :&amp;Satellite # - numéro NORAD : #.
    /// </summary>
    public static string mess11 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess11), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à IRIDIUM : Erreur rencontrée lors de l'exécution&amp;Aucun satellite Iridium susceptible de produire des flashs dans le fichier de statut.
    /// </summary>
    public static string mess12 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess12), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à IRIDIUM : Erreur rencontrée lors de l'exécution&amp;Aucun satellite Iridium n'a été trouvé dans le fichier TLE.
    /// </summary>
    public static string mess13 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess13), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à MISE A JOUR : Erreur rencontrée lors du chargement du fichier&amp;Le fichier # n'est pas un TLE.
    /// </summary>
    public static string mess14 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess14), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à MISE A JOUR : Le fichier # contient moins de satellites que le fichier #.
    /// </summary>
    public static string mess15 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess15), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à PERSONNEL : Erreur rencontrée lors du chargement du fichier #.
    /// </summary>
    public static string mess16 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess16), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à EVENEMENTS : Aucun évènement sélectionné.
    /// </summary>
    public static string mess17 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess17), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à TRANSIT : Erreur rencontrée lors du chargement du fichier&amp;Le fichier # ne contient pas le TLE de l'ISS.
    /// </summary>
    public static string mess18 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess18), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à TRANSIT : L'âge du TLE de l'ISS (# jours) est supérieur à # jours.
    /// </summary>
    public static string mess19 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess19), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à # : Le fichier # n'existe pas.</summary>
    public static string mess20 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess20), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à # : Problème de droits d'écriture du fichier #.
    /// </summary>
    public static string mess21 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess21), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à # : Aucun satellite n'est sélectionné dans la liste.
    /// </summary>
    public static string mess22 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess22), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à # : Erreur rencontrée lors de la décompression du fichier #.
    /// </summary>
    public static string mess23 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess23), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à # : Le nom du fichier # n'est pas spécifié.
    /// </summary>
    public static string mess24 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess24), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à # : Le nom du fichier TLE est incorrect.
    /// </summary>
    public static string mess25 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess25), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à # : Erreur rencontrée lors du chargement du fichier&amp;Le fichier # n'est pas un TLE.
    /// </summary>
    public static string mess26 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess26), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Le lieu d'observation "#" fait déjà partie de "Mes Préférés".
    /// </summary>
    public static string mess27 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess27), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Le nom du lieu d'observation n'est pas spécifié.
    /// </summary>
    public static string mess28 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess28), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Erreur dans la saisie de la longitude.
    /// </summary>
    public static string mess29 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess29), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Erreur dans la saisie de la latitude.
    /// </summary>
    public static string mess30 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess30), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Erreur dans la saisie de l'altitude.
    /// </summary>
    public static string mess31 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess31), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Le lieu existe déjà dans la catégorie "#".
    /// </summary>
    public static string mess32 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess32), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Le nom de la catégorie n'est pas spécifié.
    /// </summary>
    public static string mess33 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess33), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à La catégorie spécifiée existe déjà.
    /// </summary>
    public static string mess34 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess34), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Voulez-vous vraiment supprimer la catégorie "#" ?.
    /// </summary>
    public static string mess35 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (mess35), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Mise à jour automatique des TLE.</summary>
    public static string message_statut01 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut01), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Temps réel.</summary>
    public static string message_statut02 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut02), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Mode manuel.</summary>
    public static string message_statut03 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut03), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Jour julien.</summary>
    public static string message_statut04 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut04), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Jour.</summary>
    public static string message_statut05 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut05), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Date.</summary>
    public static string message_statut06 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut06), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Heure.</summary>
    public static string message_statut07 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut07), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à numéro NORAD :.</summary>
    public static string message_statut08 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut08), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Soleil.</summary>
    public static string message_statut09 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut09), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Lune.</summary>
    public static string message_statut10 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut10), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Fichier # créé.</summary>
    public static string message_statut11 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut11), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Fichier # augmenté de nouveaux satellites.
    /// </summary>
    public static string message_statut12 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut12), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Ouverture du fichier TLE....</summary>
    public static string message_statut13 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut13), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Fichier TLE OK : # satellites.</summary>
    public static string message_statut14 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut14), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à La catégorie "#" a été supprimée.
    /// </summary>
    public static string message_statut15 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut15), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à La nouvelle catégorie de lieux d'observation a été créée.
    /// </summary>
    public static string message_statut16 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut16), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Lieu d'observation déjà sélectionné.
    /// </summary>
    public static string message_statut17 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut17), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Terminé !.</summary>
    public static string message_statut18 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut18), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Calculs en cours. Veuillez patienter....
    /// </summary>
    public static string message_statut19 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut19), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Annulation du calcul des prévisions de passage.
    /// </summary>
    public static string message_statut20 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut20), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Annulation du calcul des flashs Iridium.
    /// </summary>
    public static string message_statut21 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut21), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Prévisions des flashs Iridium.</summary>
    public static string message_statut22 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut22), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Annulation du calcul des évènements orbitaux.
    /// </summary>
    public static string message_statut23 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut23), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Annulation du calcul des transits ISS.
    /// </summary>
    public static string message_statut24 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (message_statut24), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à METEOSAT-7 (MTP1)
    /// 1 24932C 97049B   14013.00000000  .00000162  00000-0  00000-0 0   134
    /// 2 24932   9.0882  50.4790 0000720 240.8804 237.6959  1.00276650    18
    /// METEOSAT-8 (MSG1)
    /// 1 27509C 02040B   14013.00000000  .00000112  00000-0  00000-0 0   139
    /// 2 27509   2.5474  62.5013 0001341 193.9593 219.4010  1.00273099    11
    /// METEOSAT-9 (MSG2)
    /// 1 28912C 05049B   14013.00000000  .00000155  00000-0  00000-0 0   137
    /// 2 28912   0.3415  24.1035 0001058 253.6625 204.1330  1.00264766    11
    /// METEOSAT [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string meteosat => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (meteosat), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à MTI
    /// 1 26102U 00014A   14019.03493267  .00007540  00000-0  32505-3 0  7324
    /// 2 26102  97.4254 148.9113 0016549  43.7284  25.9797 15.22723413763302
    /// CFESAT
    /// 1 30777U 07006F   14018.77607511  .00006340  00000-0  35714-3 0  8013
    /// 2 30777  35.4306 329.1554 0003174 323.9140  36.1364 15.12641454377927
    /// NFIRE
    /// 1 31140U 07014A   14018.14106199  .00012602  00000-0  25763-3 0  2952
    /// 2 31140  48.2178 272.8042 0063182 294.7327 219.4060 15.44271232382466
    /// SPIRALE  [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string military => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (military), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à SGP4 (DS).</summary>
    public static string modele1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (modele1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à SGP4 (NE).</summary>
    public static string modele2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (modele2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à MOLNIYA 2-9
    /// 1 07276U 74026A   14018.48987451  .00005271  00000-0  16656-2 0  8418
    /// 2 07276  62.2347  60.0472 7302284 270.8409 329.8146  2.25225514174668
    /// MOLNIYA 2-10
    /// 1 07376U 74056A   14016.53696435 -.00000761  00000-0 -53263-3 0  6926
    /// 2 07376  61.3484 149.7783 7355848 271.0074 143.9262  2.00527059288613
    /// MOLNIYA 1-S
    /// 1 07392U 74060A   14018.19618128  .00000143  00000-0  00000+0 0  2055
    /// 2 07392  11.0655 320.9284 0012227 131.9030 136.4136  1.00266571 88716
    /// MOLNIYA  [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string molniya => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (molniya), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à COSMOS 2361
    /// 1 25590U 98076A   14018.87155620  .00000072  00000-0  61027-4 0  4892
    /// 2 25590  82.9371 316.2747 0033029 105.1259 314.4002 13.72830131755069
    /// COSMOS 2378
    /// 1 26818U 01023A   14018.90637816  .00000028  00000-0  13461-4 0  6058
    /// 2 26818  82.9282 339.9678 0034595  65.6561 294.8194 13.73829669632549
    /// COSMOS 2389
    /// 1 27436U 02026A   14018.34982971  .00000041  00000-0  26924-4 0  2253
    /// 2 27436  82.9515 282.8500 0045266 307.2603 191.3496 13.74828038584276
    /// COSMOS 2 [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string musson => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (musson), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à TRANSIT 16 [?]
    /// 1 02807U 67048A   14017.90575836  .00000122  00000-0  17484-3 0   441
    /// 2 02807  89.6718 148.9947 0021556  82.1781  30.1948 13.49949954296678
    /// TRANSIT 17 [?]
    /// 1 02965U 67092A   14019.14922619  .00000107  00000-0  14421-3 0  2553
    /// 2 02965  89.2543 354.7521 0046200 245.7229 207.8866 13.52670469283794
    /// TRANSIT 18 [?]
    /// 1 03133U 68012A   14019.21420068  .00000073  00000-0  95921-4 0  6352
    /// 2 03133  89.9580 280.6992 0076018 151.7030 325.8024 13.50772562258924
    /// NNSS 19  [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string nnss => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (nnss), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à NOAA 1 [-]
    /// 1 04793U 70106A   14018.57921501 -.00000065  00000-0 -11506-3 0  8999
    /// 2 04793 101.9896  64.1153 0032354 127.1232  29.2841 12.53960984973039
    /// NOAA 2 [-]
    /// 1 06235U 72082A   14018.53790691 -.00000008  00000-0  22111-3 0  9965
    /// 2 06235 101.4960 358.1269 0003479 244.9726 227.7616 12.53045858887421
    /// NOAA 3 [-]
    /// 1 06920U 73086A   14018.53363675 -.00000023  00000-0  15074-3 0  8897
    /// 2 06920 101.7657   4.7115 0006337 253.0739 255.0017 12.40341402820104
    /// NOAA 4 [ [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string noaa => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (noaa), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à ORBCOMM-X [-]
    /// 1 21576U 91050C   14018.49653716  .00000283  00000-0  10282-3 0  4029
    /// 2 21576  98.6991   1.4314 0004673  74.9619 285.2086 14.40737466181838
    /// ORBCOMM FM01 [-]
    /// 1 23545U 95017A   14019.19158674  .00002268  00000-0  42871-3 0  6188
    /// 2 23545  69.9733 102.8122 0009750 321.7269  64.4295 14.65703721999323
    /// ORBCOMM FM02 [-]
    /// 1 23546U 95017B   14019.18099308  .00001526  00000-0  29598-3 0  6655
    /// 2 23546  69.9746 107.0021 0011981 313.2237  60.2102 14.65189157999291
    /// ORBCOMM  [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string orbcomm => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (orbcomm), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à &lt;!DOCTYPE html&gt;
    /// &lt;html lang="en"&gt;
    /// 	&lt;head&gt;
    /// 		&lt;title&gt;Orbit3D 20.04.15 @08:15 UTC&lt;/title&gt;
    /// 		&lt;meta charset="utf-8"&gt;
    /// 		&lt;meta name="viewport" content="width=device-width, user-scalable=no, minimum-scale=1.0, maximum-scale=1.0"&gt;
    /// 		&lt;style&gt;
    /// 			body {
    /// 				color: #000;
    /// 				font-family:Monospace;
    /// 				font-size:13px;
    /// 				text-align:center;
    /// 				font-weight: bold;
    /// 
    /// 				background-color: #fff;
    /// 				margin: 0px;
    /// 				overflow: hidden;
    /// 			}
    /// 
    /// 			#info {
    /// 				color:#000;
    /// 				position: absolute;
    /// 				top: 0px;  [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string Orbit3D => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (Orbit3D), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à /**
    ///  * @author qiao / https://github.com/qiao
    ///  * @author mrdoob / http://mrdoob.com
    ///  * @author alteredq / http://alteredqualia.com/
    ///  * @author WestLangley / http://github.com/WestLangley
    ///  * @author erich666 / http://erichaines.com
    ///  */
    /// /*global THREE, console */
    /// 
    /// // This set of controls performs orbiting, dollying (zooming), and panning. It maintains
    /// // the "up" direction as +Y, unlike the TrackballControls. Touch on tablet and phones is
    /// // supported.
    /// //
    /// //    Orbit - left mouse / touch: one finger move
    /// //   [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string OrbitControls => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (OrbitControls), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à CELESTIS-02
    /// 1 25160U 98007D   14018.24381073  .00000008  00000-0  61628-4 0  3809
    /// 2 25160 107.9537 210.9610 0064014 336.2145 113.4717 14.21161566826526
    /// CELESTIS-03
    /// 1 26034U 99070C   14018.53303563  .00005749  00000-0  61701-3 0  9894
    /// 2 26034  98.2223 118.1300 0014814 348.4312  11.6562 14.88939168758716
    /// .
    /// </summary>
    public static string other => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (other), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à SIRIUS-1
    /// 1 26390U 00035A   14016.50794412  .00000095  00000-0  00000+0 0  2774
    /// 2 26390  60.1189 241.2128 2694925 270.8720  50.0136  1.00276437 49626
    /// SIRIUS-2
    /// 1 26483U 00051A   14013.21942005 -.00000046  00000-0  00000+0 0  9104
    /// 2 26483  64.1446 121.5164 2720660 268.8565  66.4905  1.00276878 48936
    /// SIRIUS-3
    /// 1 26626U 00077A   14018.35149472 -.00000117  00000-0  00000+0 0  2492
    /// 2 26626  64.4693   1.2246 2688592 268.8638 239.3966  1.00274410 48113
    /// XM-2 (RO [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string other_comm => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (other_comm), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Ouvrir fichier TLE.</summary>
    public static string ouvrir_tle => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (ouvrir_tle), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à # (#).</summary>
    public static string perigee => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (perigee), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à PERSONNEL.</summary>
    public static string personnel1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (personnel1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à à lire.</summary>
    public static string personnel2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (personnel2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à personnel.</summary>
    public static string personnel3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (personnel3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Enregistrer fichier TLE personnel.
    /// </summary>
    public static string personnel4 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (personnel4), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Fichier # écrit.</summary>
    public static string personnel5 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (personnel5), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Nouvelle Lune.</summary>
    public static string phase_lune1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (phase_lune1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Premier croissant.</summary>
    public static string phase_lune2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (phase_lune2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Dernier croissant.</summary>
    public static string phase_lune3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (phase_lune3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Premier quartier.</summary>
    public static string phase_lune4 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (phase_lune4), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Dernier quartier.</summary>
    public static string phase_lune5 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (phase_lune5), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Gibbeuse croissante.</summary>
    public static string phase_lune6 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (phase_lune6), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Gibbeuse décroissante.</summary>
    public static string phase_lune7 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (phase_lune7), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Pleine lune.</summary>
    public static string phase_lune8 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (phase_lune8), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à POSITION.</summary>
    public static string position1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (position1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à POSITION : Erreur rencontrée lors de l'initialisation&amp;Le répertoire # n'existe pas, veuillez réinstaller PreviSat.
    /// </summary>
    public static string position2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (position2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à PREVISION.</summary>
    public static string prevision1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (prevision1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Prévisions de passage des satellites.
    /// </summary>
    public static string prevision2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (prevision2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à    Date     Heure    Azimut Sat Hauteur Sat  AD Sat    Decl Sat  Const Magn  Altitude  Distance  Az Soleil   Haut Soleil.
    /// </summary>
    public static string prevision3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (prevision3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à /**
    ///  * @author mrdoob / http://mrdoob.com/
    ///  * @author supereggbert / http://www.paulbrunt.co.uk/
    ///  * @author julianwa / https://github.com/julianwa
    ///  */
    /// 
    /// THREE.RenderableObject = function () {
    /// 
    /// 	this.id = 0;
    /// 
    /// 	this.object = null;
    /// 	this.z = 0;
    /// 
    /// };
    /// 
    /// //
    /// 
    /// THREE.RenderableFace = function () {
    /// 
    /// 	this.id = 0;
    /// 
    /// 	this.v1 = new THREE.RenderableVertex();
    /// 	this.v2 = new THREE.RenderableVertex();
    /// 	this.v3 = new THREE.RenderableVertex();
    /// 
    /// 	this.normalModel = new THREE.Vector3();
    /// 
    /// 	this.vertexNormalsModel = [ new THREE.Vect [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string Projector => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (Projector), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à CALSPHERE 1
    /// 1 00900U 64063C   14018.89095757  .00000509  00000-0  55165-3 0  2073
    /// 2 00900  90.1418 352.9898 0025244 251.5096 108.3323 13.71761404449194
    /// CALSPHERE 2
    /// 1 00902U 64063E   14018.87718348  .00000059  00000-0  74649-4 0  9246
    /// 2 00902  90.1444 355.3959 0019748  66.9286 356.5725 13.52562916244003
    /// LCS 1
    /// 1 01361U 65034C   14018.54668564  .00000008  00000-0  00000+0 0  5057
    /// 2 01361  32.1403 138.9627 0012025 293.9970 151.2223  9.89285786761362
    /// TEMPSAT  [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string radar => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (radar), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à RADUGA 1 [-]
    /// 1 08513U 75123A   14018.74497670 -.00000067  00000-0  00000+0 0  4777
    /// 2 08513  12.2371 325.9033 0009628 137.0652 355.7020  1.00248149149497
    /// RADUGA 2 [-]
    /// 1 09416U 76092A   14018.13066722 -.00000011  00000-0  00000+0 0  9953
    /// 2 09416  12.7877 327.9542 0025324 256.8902   4.8071  1.00286184 83881
    /// RADUGA 3 [-]
    /// 1 10159U 77071A   14018.12531228  .00000136  00000-0  00000+0 0  4428
    /// 2 10159  13.2559 330.3259 0011952 151.4749  75.1475  1.00277888131596
    /// RADUGA 4 [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string raduga => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (raduga), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à TLE ANALYSER - V2.13
    /// &gt; Daily updated TLE
    /// &gt; Prediction wrt NORAD SGP4/SDP4 model
    /// &gt; Osculating elements
    /// &gt; Flat 2D map and 3D earth map
    /// &gt; Ground Stations
    /// &gt; Export to GMAT for mission analysis
    /// &gt; Export to Celestia &amp; Google Earth KML format
    /// 
    /// https://sourceforge.net/projects/tleanalyser/
    /// http://tleanalyser.blogspot.fr/
    /// 
    /// &gt; Last Update (xx/xx/2014):
    /// ---------------------------
    /// 
    /// - Improvement of:
    /// 	- Mean Altitude calculation
    /// 	- TLE Time format calculation (Epoch format option)
    /// 	- Osculating element [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string README => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (README), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à /**
    ///  * @author alteredq / http://alteredqualia.com/
    ///  */
    /// 
    /// THREE.RenderPass = function ( scene, camera, overrideMaterial, clearColor, clearAlpha ) {
    /// 
    /// 	this.scene = scene;
    /// 	this.camera = camera;
    /// 
    /// 	this.overrideMaterial = overrideMaterial;
    /// 
    /// 	this.clearColor = clearColor;
    /// 	this.clearAlpha = ( clearAlpha !== undefined ) ? clearAlpha : 1;
    /// 
    /// 	this.oldClearColor = new THREE.Color();
    /// 	this.oldClearAlpha = 1;
    /// 
    /// 	this.enabled = true;
    /// 	this.clear = true;
    /// 	this.needsSwap = false;
    /// 
    /// };
    /// 
    /// THREE.RenderPass.prototype = {
    /// 
    /// 	rende [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string RenderPass => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (RenderPass), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à SCD 1
    /// 1 22490U 93009B   14019.20559391  .00000384  00000-0  57233-4 0  3158
    /// 2 22490  24.9711  48.5936 0042863 155.6048 285.6382 14.43982965105427
    /// TRMM
    /// 1 25063U 97074A   14019.20201339  .00018803  00000-0  26367-3 0  5395
    /// 2 25063  34.9581  45.8134 0000983 237.4452 186.7319 15.55796725921470
    /// TECHSAT 1B (GO-32)
    /// 1 25397U 98043D   14018.51859049  .00000087  00000-0  56962-4 0  2568
    /// 2 25397  98.4484 342.2616 0001970  64.4727  56.1170 14.23394579806579
    /// SCD 2    [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string resource => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (resource), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à SARSAT 7 (NOAA 15)
    /// 1 25338U 98030A   14018.53559127  .00000154  00000-0  84145-4 0   416
    /// 2 25338  98.7434  12.7741 0010121 217.6375 250.3965 14.25328142815529
    /// SARSAT 8 (NOAA 16)
    /// 1 26536U 00055A   14018.48424966  .00000047  00000-0  49748-4 0  5284
    /// 2 26536  99.0122  78.0535 0009850 244.8522 238.7958 14.12974936686978
    /// GPS BIIR-07
    /// 1 26690U 01004A   14018.32813472  .00000055  00000-0  00000+0 0  1083
    /// 2 26690  53.0744 209.8862 0148572 242.0260 247.9573  2.00563736 95043
    /// GPS BIIR [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string sarsat => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sarsat), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap Sat => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (Sat), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap sat2 => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (sat2), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap Sat3 => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (Sat3), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>
    ///   Recherche une chaîne localisée semblable à AFETR;Air Force Eastern Test Range, Florida, USA
    /// AFWTR;Air Force Western Test Range, California, USA
    /// CAS;Canaries Airspace
    /// DLS;Dombarovskiy Launch Site, Russia
    /// ERAS;Eastern Range Airspace
    /// FRGUI;Europe's Spaceport, Kourou, French Guiana
    /// HGSTR;Hammaguira Space Track Range, Algeria
    /// JSC;Jiuquan Space Center, PRC
    /// KODAK;Kodiak Launch Complex, Alaska, USA
    /// KSCUT;Uchinoura Space Center, Japan
    /// KWAJ;US Army Kwajalein Atoll (USAKA)
    /// KYMSC;Kapustin Yar Missile and Space Complex, Russia
    /// NSC;Naro Space Complex, [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string satcat_sites => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (satcat_sites), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à AB;Arab Satellite Communications Organization
    /// ABS;Asia Broadcast Satellite
    /// AC;ASIASAT
    /// ALG;Algeria
    /// ARGN;Argentina
    /// ASRA;Austria
    /// AUS;Australia
    /// AZER;Azerbaijan
    /// BELA;Belarus
    /// BERM;Bermuda
    /// BOL;Bolivia
    /// BRAZ;Brazil
    /// CA;Canada
    /// CHBZ;China/Brazil
    /// CHLE;Chile
    /// CIS;Commonwealth of Independent States
    /// COL;Colombia
    /// CZCH;Czech Republic
    /// DEN;Denmark
    /// ECU;Ecuador
    /// EGYP;Egypt
    /// ESA;European Space Agency
    /// ESRO;European Space Research Organization
    /// EST;Estonia
    /// EUME;EUMETSAT
    /// EUTE;EUTELSAT
    /// FGER;France/Germany
    /// FR;Fr [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string satcat_sources => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (satcat_sources), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à {\rtf1\ansi\ansicpg1252\deff0{\fonttbl{\f0\fnil\fcharset0 Courier New;}{\f1\fmodern\fprq1\fcharset0 Courier New;}{\f2\fnil Consolas;}}
    /// {\colortbl ;\red0\green0\blue0;\red163\green21\blue21;}
    /// {\*\generator Msftedit 5.41.21.2509;}\viewkind4\uc1\pard\lang1033\f0\fs20 &lt;?xml version="1.0" encoding="UTF-8"?&gt;\par
    /// &lt;kml xmlns="http://www.opengis.net/kml/2.2" xmlns:gx="http://www.google.com/kml/ext/2.2" xmlns:kml="http://www.opengis.net/kml/2.2" xmlns:atom="http://www.w3.org/2005/Atom" hint="target=earth"&gt;\par
    /// &lt;D [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string satellite_KML => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (satellite_KML), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Looks up a localized resource of type System.Byte[].</summary>
    public static byte[] satellite_PNG => (byte[]) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (satellite_PNG), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>Recherche une chaîne localisée semblable à Date :.</summary>
    public static string sauvegarde01 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde01), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Lieu d'observation :.</summary>
    public static string sauvegarde02 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde02), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Longitude : #   Latitude : #   Altitude : #.
    /// </summary>
    public static string sauvegarde03 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde03), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Nom du satellite : #.</summary>
    public static string sauvegarde04 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde04), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Longitude : #$Hauteur    : #$Ascension droite :  #.
    /// </summary>
    public static string sauvegarde05 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde05), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Latitude  :  #$Azimut (N) : #$Déclinaison      : #.
    /// </summary>
    public static string sauvegarde06 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde06), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Altitude  :  #$Distance   : #$Constellation    : #.
    /// </summary>
    public static string sauvegarde07 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde07), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Direction          : #  $#.</summary>
    public static string sauvegarde08 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde08), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Vitesse orbitale   : #  $Conditions d'observation : #.
    /// </summary>
    public static string sauvegarde09 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde09), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Variation distance : #  $Orbite n°#.
    /// </summary>
    public static string sauvegarde10 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde10), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Coordonnées du Soleil :.</summary>
    public static string sauvegarde11 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde11), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Hauteur    : #$Ascension droite :  #.
    /// </summary>
    public static string sauvegarde12 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde12), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Azimut (N) : #$Déclinaison      : #.
    /// </summary>
    public static string sauvegarde13 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde13), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Distance   : #   $Constellation    : #.
    /// </summary>
    public static string sauvegarde14 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde14), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Coordonnées de la Lune :.</summary>
    public static string sauvegarde15 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde15), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Phase        :.</summary>
    public static string sauvegarde16 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde16), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Illumination :.</summary>
    public static string sauvegarde17 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde17), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à SAUVEGARDE.</summary>
    public static string sauvegarde18 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde18), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Numéro NORAD            : #$$$Moyen mouvement       : # rev/jour.
    /// </summary>
    public static string sauvegarde19 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde19), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Désignation COSPAR      : #$$n'/2                  : # rev/jour^2.
    /// </summary>
    public static string sauvegarde20 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde20), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Epoque (UTC)            : #$n"/6                  : # rev/jour^3.
    /// </summary>
    public static string sauvegarde21 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde21), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Coeff pseudo-balistique : #  (1/Re) $Nb orbites à l'époque : #.
    /// </summary>
    public static string sauvegarde22 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde22), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Inclinaison             : #$$Anomalie moyenne      : #.
    /// </summary>
    public static string sauvegarde23 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde23), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à AD noeud ascendant      : #$$Magnitude std/max     : #.
    /// </summary>
    public static string sauvegarde24 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde24), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Excentricité            : #$$Modèle orbital        : #.
    /// </summary>
    public static string sauvegarde25 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde25), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Argument du périgée     : #$$Dimensions/Section    : #^2.
    /// </summary>
    public static string sauvegarde26 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde26), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Vecteur d'état (ECI) :$$$$Éléments osculateurs :.
    /// </summary>
    public static string sauvegarde27 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde27), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à x : #$vx : #$Demi-grand axe : #$Ascension droite du noeud ascendant : #.
    /// </summary>
    public static string sauvegarde28 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde28), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à y : #$vy : #$Excentricité   : #$Argument du périgée                 : #.
    /// </summary>
    public static string sauvegarde29 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde29), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à z : #$vz : #$Inclinaison    : #$Anomalie moyenne                    : #.
    /// </summary>
    public static string sauvegarde30 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde30), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Anomalie vraie       : #$$Apogée  (Altitude) : #.
    /// </summary>
    public static string sauvegarde31 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde31), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Anomalie excentrique : #$$Périgée (Altitude) : #.
    /// </summary>
    public static string sauvegarde32 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde32), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Champ de vue         : #$$Période orbitale   : #.
    /// </summary>
    public static string sauvegarde33 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sauvegarde33), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à AOR-E (EGNOS/PRN 120)
    /// 1 24307U 96053A   14018.85895539 -.00000121  00000-0  10000-3 0   445
    /// 2 24307   0.0769  87.8523 0006345 205.3903 118.6380  1.00271944 63603
    /// ARTEMIS (EGNOS/PRN 124)
    /// 1 26863U 01029A   14018.26563948  .00000116  00000-0  10000-3 0  6409
    /// 2 26863  11.0165  47.1614 0003890 267.0759 280.3613  1.00272620 46968
    /// MTSAT-1R (MSAS/PRN 129)
    /// 1 28622U 05006A   14018.88909726 -.00000278  00000-0  10000-3 0   324
    /// 2 28622   0.0238 103.2531 0001407 306.0148 169.0272  1.00271903 32560
    /// CRE (WAA [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string sbas => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (sbas), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à AKEBONO (EXOS-D)
    /// 1 19822U 89016A   14018.20198035  .00034096 -52165-7  85786-3 0  7701
    /// 2 19822  75.0586 197.8771 2313933 127.0873 358.1246 10.81279778768254
    /// HST
    /// 1 20580U 90037B   14019.20156808  .00001836  00000-0  11584-3 0  4196
    /// 2 20580  28.4700 295.9148 0003068 133.4275  21.7627 15.04534548102252
    /// POLAR
    /// 1 23802U 96013A   14017.66508471 -.00000138  00000-0  00000+0 0  5363
    /// 2 23802  80.0336 299.9991 7046535  15.3703 287.9168  1.29843500 85987
    /// SWAS     [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string science => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (science), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Connexion au serveur impossible.</summary>
    public static string serveur1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (serveur1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Aucune mise à jour nécessaire.</summary>
    public static string serveur2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (serveur2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à La prise en compte des fichiers téléchargés nécessite un redémarrage de PreviSat.
    /// </summary>
    public static string serveur3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (serveur3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Télécharger....</summary>
    public static string serveur4 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (serveur4), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Chargement en cours....</summary>
    public static string serveur5 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (serveur5), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Chargement terminé !.</summary>
    public static string serveur6 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (serveur6), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à NSS-703
    /// 1 23305C 94064A   14018.11458333 -.00000187  00000-0  00000-0 0   187
    /// 2 23305   3.7261  66.0390 0004058 223.1293 182.4470  1.00273565    13
    /// AMC-1 (GE-1)
    /// 1 24315C 96054A   14018.11458333 -.00000012  00000-0  00000-0 0   187
    /// 2 24315   0.0287 324.8614 0003645 349.0529 101.7534  1.00272005    11
    /// AMC-3 (GE-3)
    /// 1 24936C 97050A   14018.11458333 -.00000184  00000-0  00000-0 0   183
    /// 2 24936   0.0495 251.4832 0003058  43.6079 156.5781  1.00273357    16
    /// NSS-5    [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string ses => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (ses), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à /**
    ///  * @author alteredq / http://alteredqualia.com/
    ///  */
    /// 
    /// THREE.ShaderPass = function ( shader, textureID ) {
    /// 
    /// 	this.textureID = ( textureID !== undefined ) ? textureID : "tDiffuse";
    /// 
    /// 	this.uniforms = THREE.UniformsUtils.clone( shader.uniforms );
    /// 
    /// 	this.material = new THREE.ShaderMaterial( {
    /// 
    ///         	defines: shader.defines || {},
    /// 		uniforms: this.uniforms,
    /// 		vertexShader: shader.vertexShader,
    /// 		fragmentShader: shader.fragmentShader
    /// 
    /// 	} );
    /// 
    /// 	this.renderToScreen = false;
    /// 
    /// 	this.enabled = true;
    /// 	this.needsSwa [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string ShaderPass => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (ShaderPass), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à ISS (ZARYA)
    /// 1 25544U 98067A   14019.26838948 -.00103351  00000-0 -18425-2 0  4962
    /// 2 25544  51.6522 117.7245 0003714  42.9242 356.1506 15.49754632868226
    /// TIANGONG 1
    /// 1 37820U 11053A   14019.21566097  .00045574  00000-0  32055-3 0  6834
    /// 2 37820  42.7753 131.8268 0008885 359.2437  77.9986 15.73305849132637
    /// ARDUSAT-1
    /// 1 39412U 98067DA  14019.08570844  .00069792  00000-0  86152-3 0  1833
    /// 2 39412  51.6495 116.4534 0004790 306.3694 113.7311 15.59500158  9416
    /// PICODRAG [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string stations => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (stations), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à // stats.js - http://github.com/mrdoob/stats.js
    /// var Stats=function(){var l=Date.now(),m=l,g=0,n=Infinity,o=0,h=0,p=Infinity,q=0,r=0,s=0,f=document.createElement("div");f.id="stats";f.addEventListener("mousedown",function(b){b.preventDefault();t(++s%2)},!1);f.style.cssText="width:80px;opacity:0.9;cursor:pointer";var a=document.createElement("div");a.id="fps";a.style.cssText="padding:0 0 3px 3px;text-align:left;background-color:#002";f.appendChild(a);var i=document.createElement("div");i.id="fpsText";i.style. [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string stats_min => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (stats_min), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Looks up a localized resource of type System.Drawing.Bitmap.</summary>
    public static Bitmap sun => (Bitmap) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (sun), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>
    ///   Recherche une chaîne localisée semblable à gps
    /// glonass
    /// meteosat
    /// ses.
    /// </summary>
    public static string SuppList => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (SuppList), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Looks up a localized resource of type System.Byte[].</summary>
    public static byte[] TAUM => (byte[]) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (TAUM), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>
    ///   Recherche une chaîne localisée semblable à TDRS 3
    /// 1 19548U 88091B   14017.31546959 -.00000295  00000-0  10000-3 0  2138
    /// 2 19548  14.3436  21.5320 0015537 331.0824 188.7051  1.00267760 79932
    /// HST
    /// 1 20580U 90037B   14019.20156808  .00001836  00000-0  11584-3 0  4196
    /// 2 20580  28.4700 295.9148 0003068 133.4275  21.7627 15.04534548102252
    /// TDRS 5
    /// 1 21639U 91054B   14018.34155251  .00000095  00000-0  00000+0 0  4673
    /// 2 21639  13.0825  35.4899 0012238 325.4607  71.9600  1.00270715 82278
    /// TDRS 6   [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string tdrss => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (tdrss), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Looks up a localized resource of type System.Byte[].</summary>
    public static byte[] TemplateKML => (byte[]) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (TemplateKML), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>
    ///   Recherche une chaîne localisée semblable à // threejs.org/license
    /// 'use strict';var THREE={REVISION:"71"};"object"===typeof module&amp;&amp;(module.exports=THREE);void 0===Math.sign&amp;&amp;(Math.sign=function(a){return 0&gt;a?-1:0&lt;a?1:+a});THREE.log=function(){console.log.apply(console,arguments)};THREE.warn=function(){console.warn.apply(console,arguments)};THREE.error=function(){console.error.apply(console,arguments)};THREE.MOUSE={LEFT:0,MIDDLE:1,RIGHT:2};THREE.CullFaceNone=0;THREE.CullFaceBack=1;THREE.CullFaceFront=2;THREE.CullFaceFrontBack=3;THREE.FrontFaceDirecti [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string three_min => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (three_min), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Information.</summary>
    public static string titre1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (titre1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Erreur.</summary>
    public static string titre2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (titre2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Avertissement.</summary>
    public static string titre3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (titre3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à TKSAT-1 (TUPAC KATARI)
    /// 1 39481U 13075A   14018.04587799 -.00000194  00000-0  10000-3 0   196
    /// 2 39481   0.2280 270.9799 0003286  44.8732  90.8352  1.00270859   390
    /// CZ-3B R/B
    /// 1 39482U 13075B   14016.90651860  .00013669  14369-5  12606-2 0   259
    /// 2 39482  24.7078 329.6634 7685278 193.3062 118.8803  1.81771064   493
    /// COSMOS 2488
    /// 1 39483U 13076A   14019.03449157  .00000010  00000-0  00000+0 0   702
    /// 2 39483  82.4881 113.1809 0018694 256.0192 103.8799 12.42993557  3070
    /// COSMOS 2 [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string tle_new => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (tle_new), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à [TLE]
    /// date=
    /// version=
    /// 
    /// [Tracking Options]
    /// speed=100
    /// SatVisual1=False
    /// SatVisual2=True
    /// SatVisual3=False
    /// Simulation On=False
    /// RealTimeStep=1
    /// 
    /// [GMAT Export]
    /// show track=True
    /// OptionGmatModel1=False
    /// OptionGmatModel2=True
    /// propagate=1
    /// 
    /// [TLE Options]
    /// LoadTleNow=False
    /// LoadTleEpoch=True
    /// 
    /// [Ground Stations]
    /// GSFullName=False
    /// GSShortName=True
    /// LimitAngle=90
    /// 
    /// [Elements Options]
    /// EquRadius=False.
    /// </summary>
    public static string tlea => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (tlea), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icône).
    /// </summary>
    public static Icon TLEA_ICO => (Icon) RuntimeHelpers.GetObjectValue(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(nameof (TLEA_ICO), TLE_Analyser.My.Resources.Resources.resourceCulture));

    /// <summary>
    ///   Recherche une chaîne localisée semblable à amateur
    /// beidou
    /// cubesat
    /// dmc
    /// education
    /// engineering
    /// galileo
    /// geo
    /// geodetic
    /// globalstar
    /// glo-ops
    /// goes
    /// gorizont
    /// gps-ops
    /// intelsat
    /// iridium
    /// military
    /// molniya
    /// musson
    /// nnss
    /// noaa
    /// orbcomm
    /// other
    /// other-comm
    /// radar
    /// raduga
    /// resource
    /// sarsat
    /// sbas
    /// science
    /// stations
    /// tdrss
    /// tle-new
    /// visual
    /// weather
    /// x-comm
    /// .
    /// </summary>
    public static string TLEList => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (TLEList), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à TRANSIT.</summary>
    public static string transit01 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (transit01), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Transits ISS.</summary>
    public static string transit02 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (transit02), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à T.</summary>
    public static string transit03 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (transit03), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à C.</summary>
    public static string transit04 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (transit04), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à S.</summary>
    public static string transit05 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (transit05), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à L.</summary>
    public static string transit06 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (transit06), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Omb.</summary>
    public static string transit07 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (transit07), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Pen.</summary>
    public static string transit08 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (transit08), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Lum.</summary>
    public static string transit09 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (transit09), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à    Date      Heure    Azimut Sat Hauteur Sat  AD Sat    Decl Sat  Cst  Ang  Type Corps Ill   Alt   Dist  Az Soleil  Haut Soleil.
    /// </summary>
    public static string transit10 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (transit10), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à h.</summary>
    public static string unite_heure1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (unite_heure1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à m.</summary>
    public static string unite_heure2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (unite_heure2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à s.</summary>
    public static string unite_heure3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (unite_heure3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à km.</summary>
    public static string unite1 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (unite1), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à mi.</summary>
    public static string unite2 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (unite2), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à km/s.</summary>
    public static string unite3 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (unite3), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à mi/s.</summary>
    public static string unite4 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (unite4), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à UA.</summary>
    public static string unite5 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (unite5), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à m.</summary>
    public static string unite6 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (unite6), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à ft.</summary>
    public static string unite7 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (unite7), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à MISE A JOUR.</summary>
    public static string update01 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (update01), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à à mettre à jour.</summary>
    public static string update02 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (update02), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à à lire.</summary>
    public static string update03 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (update03), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à TLE du satellite # (#) non réactualisé.
    /// </summary>
    public static string update04 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (update04), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à # TLE(s) sur # mis à jour.</summary>
    public static string update05 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (update05), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Mise à jour de tous les TLE effectuée (fichier de # satellite(s)).
    /// </summary>
    public static string update06 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (update06), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Aucun TLE mis à jour.</summary>
    public static string update07 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (update07), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Mise à jour de la catégorie effectuée.
    /// </summary>
    public static string update08 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (update08), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Voulez-vous vraiment supprimer ce(s) fichier(s) de la catégorie "#" ?.
    /// </summary>
    public static string update09 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (update09), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>Recherche une chaîne localisée semblable à Le groupe "#" existe déjà.</summary>
    public static string update10 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (update10), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Le nom du domaine n'est pas spécifié.
    /// </summary>
    public static string update11 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (update11), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à Le nom du groupe n'est pas spécifié.
    /// </summary>
    public static string update12 => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (update12), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à ATLAS CENTAUR 2
    /// 1 00694U 63047A   14018.82197563  .00000932  00000-0  11518-3 0  4172
    /// 2 00694  30.3556 164.1822 0602124  46.4333  68.3292 13.98608291507958
    /// THOR AGENA D R/B
    /// 1 00733U 64002A   14018.43707583  .00000187  00000-0  87185-4 0  1391
    /// 2 00733  98.9898 132.5074 0034153 198.9773 202.5532 14.31751263604011
    /// SL-3 R/B
    /// 1 00877U 64053B   14018.18873600  .00000119  00000-0  49529-4 0  4895
    /// 2 00877  65.0805 331.8404 0082141 246.3785 112.8674 14.58705140619721
    /// SL-8 R/B [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string visual => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (visual), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à METEOSAT-7
    /// 1 24932U 97049B   14018.10954322  .00000056  00000-0  10000-3 0   153
    /// 2 24932   8.8231  49.7899 0000759 257.2191 267.4460  1.00278035 59995
    /// NOAA 15
    /// 1 25338U 98030A   14018.53559127  .00000154  00000-0  84145-4 0   416
    /// 2 25338  98.7434  12.7741 0010121 217.6375 250.3965 14.25328142815529
    /// NOAA 16
    /// 1 26536U 00055A   14018.48424966  .00000047  00000-0  49748-4 0  5284
    /// 2 26536  99.0122  78.0535 0009850 244.8522 238.7958 14.12974936686978
    /// FENGYUN  [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string weather => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (weather), TLE_Analyser.My.Resources.Resources.resourceCulture);

    /// <summary>
    ///   Recherche une chaîne localisée semblable à APRIZESAT 2
    /// 1 28366U 04025A   14018.38791057  .00000139  00000-0  58618-4 0  6712
    /// 2 28366  98.2942 317.4293 0108875 177.3383 182.8407 14.36106081500747
    /// SAUDICOMSAT 1
    /// 1 28369U 04025D   14018.82068539  .00000380  00000-0  10524-3 0  7415
    /// 2 28369  98.0225 357.7171 0032741 267.7592  91.9855 14.51449912506066
    /// SAUDICOMSAT 2
    /// 1 28370U 04025E   14018.45808117  .00000398  00000-0  12036-3 0  7374
    /// 2 28370  98.1375 343.2866 0058107 354.4932   5.5615 14.46499128504311
    /// APRIZESA [le reste de la chaîne a été tronqué]";.
    /// </summary>
    public static string x_comm => TLE_Analyser.My.Resources.Resources.ResourceManager.GetString(nameof (x_comm), TLE_Analyser.My.Resources.Resources.resourceCulture);
  }
}
