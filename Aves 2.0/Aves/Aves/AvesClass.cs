using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aves
{
    class AvesClass
    {
        public List<AvesBD> aves{get; set;}
        public AvesClass()
        {
            aves = new List<AvesBD>()
            {
                new AvesBD()
                {
                    id=1,
                    idHabitat = 0,
                    nomAve = "Aguila",
                    urlSonido="sonidos/aguila.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Aguila \n\n"+
                            "DISTRIBUCIÓN EN CHILE: \nNormalmente entre Arica e Iquique y desde Caldera a Tierra del Fuego.\n"+
							"\nHABITAT:\nen todo lugar, pero más numerosa en las zonas bajas de las cordilleras de la zona central.\nDESCRIPCIÓN:\n"+
							" Largo: 70 cms.\nMacho: Cabeza, cuello, dorso, pecho, supracaudales y cola negros azulados. Garganta, abdómen, subcaudales"+
							" y calzones blancos con estrias finas oscuras. Alas negras con cubiertas alares grisáceas parte interior de las alas blanco"+
							" sucio con estrias finas oscuras. Pico ganchudo, gris azulado en la punta y amarillento hacia la base. Patas amarillas con"+
							" grandes uñas negras. \nHembra: similar al macho, pero más grande y con las cubiertas secundarias y las supracaudales con"+
							" tono rufo.\nInmaduro: de color oscuro casi negro, con tonos de castaño rojizo. Por debajo más claro. Llega a su plumaje"+
							"de adulto a los 3 o 4 años.",
                    Datos="Esquiva y desconfiada, por lo que difícilmente se le puede ver de cerca. Le gusta volar aprovechando las corrientes de aire"+
							" pudiendo vérsele en grandes planeos circulares. Su alimento consiste en animales vivos, como conejos, ratones,"+
							" culebras, perdices y otros, los cuales caza lanzándose en picada y apresándolos con sus poderosas patas, para luego"+
							" matarlos enterrándoles su fuertes uñas o dándole golpes con su pico. Luego los lleva a un risco o a su nido para comérselo"+
							" o alimentar a su familia. \n Construyen un nido voluminoso con ramas secas entrelazadas y forrado con crin o lana, en salientes"+
							" o grietas de riscos, o en la copa de grandes árboles, nido que les puede servir durante varios años si no son molestados, ya que"+
							" suelen parearse por toda la vida. Ponen generalmente 2 huevos, a veces 1 y rara vez 3, de color blanco o blanco con algunas"+
							" pintas pardas, de dimensiones de 67 mm. x 52 mm. app."
                },
                new AvesBD()
                {
                    id=2,
                    idHabitat = 0,
                    nomAve = "Bandurria",
                    urlSonido="sonidos/bandurria.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Bandurria \n"+
                            "DISTRIBUCIÓN EN CHILE:\n desde Antofagasta a Tierra del Fuego \nHABITAT:zonas pantanosas y orillas"+
							"de lagos y lagunas. También en campos arados y sembrados.\n\nDESCRIPCIÓN:\nLargo: 73 cms.\nCabeza y cuello amarillento ocráceo"+
							" con corona y nuca más oscuras. Pecho blanquesino separado del cuello por una linea gris. Lados del pecho y abdÓmen negros."+
							" Dorso pardo grisáceo. Cubiertas alares menores y medianas blancas con bordes grises oscuros las mayores blanco grisáceas."+
							" Primarias negras. Ojos, lorums y garganda desnuda de color negro. Pico largo curvado hacia abajo, negro la mitad basal y córneo"+
							"el resto. Iris y patas rojas a rosadas.",
                    Datos="De forma y colores muy característicos, es fácilmente reconocible. Se alimenta de sapos, renacuajos, lombrices, insectos y"+
							" otros animales semejantes que captura a orillas de lagos, lagunas o embalses. También visita los campos arados y sembrados,"+
							"en donde es fácil encontrar alguna pequeña bandada separada.\nAunque su zona de distribucion va desde Antofagasta a Tierra del"+
							" Fuego, es un ave rara en su rango norte y centro, y bastante común entre ConcepciÓn (8° RegiÓn) y el sur de la 10° Región, siendo"+
							" una especie migratoria de invierno hacia la parte norte y migratoria de verano hacia la parte sur de su zona de distribución.\n"+
							"Anida en grietas o salientes de riscos en los cerros interiores, acantilados costeros y en árboles. El nido está hecho de palos"+
							" secos y tallos de pasto, muy voluminoso y mal terminado. La nidada consta de 2 a 3 huevos, de fondo blanquesino con pequeñas"+
							" pintas café claro. Dimensiones de 65 mm. x 44 mm. app.. Las posturas son entre Octubre y Diciembre, pero hacia el extremo sur"+
							" pueden retrasarse un poco."
                }, 
                new AvesBD()
                {
                    id=3,
                    idHabitat = 0,
                    nomAve = "Becacina",
                    urlSonido="sonidos/becacina.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Becacina, porotera\n\nDISTRIBUCIÓN EN CHILE:\nAtacama al Cabo de Hornos\nHABITAT:Zonas pantanosas, vegas, bofedales,"+
							" bordes de aguas calmas. \n\nDESCRIPCION:\nLargo: 32 cms.\nCabeza parda con lineas claras que salen de la base del pico hacia la"+
							" nuca; una sobre el ojo y otra bajo el ojo. Espalda manchada con tonos negros, cafe amarillento y marron, muy variegados. Cuello"+
							" y pecho de igual tono pero con variegados mas claros y finos. Flancos blancos con lineas transversales negruzcas. Abdomen blanco."+
							" Pico recto, largo (69 mm.) de color verdoso oscuro. Patas amarillo verdosas.\n\nALIMENTACION:\nInsectos, larvas y lombrices que busca"+
							" enterrando su largo pico en el barro. Como toda ave de su tipo, el pico es sensible al tacto, por lo que al chocar con algun"+
							" insecto o gusano oculto en el barro, este se cierra en un acto reflejo.\n\nREPRODUCCION:\nAve de pantano y potreros humedos, anida"+
							" en el suelo en un sector un poco mas alto y seco que el resto. El nido esta hecho de pastos o juncos. Coloca generalmente 2"+
							" huevos ovalados-puntiagudos, de color verde olivaceo con manchitas concentradas en el borde mas romo; dimensiones de 44 x 31 mm."+
							"app. Una caracteristica de esta ave es que nidifica muy temprano, entre los meses de Junio y Julio, es decir, en pleno invierno.",
                    Datos="OBSERVACIONES:Durante la epoca de reproduccion o en ciertas actitudes territoriales realiza un vuelo muy tipico, que consiste en"+
							" tomar altura, volar en circulos y luego lanzarse en picada desde unos 10 mts., produciendo un sonido muy caracteristico. Esto lo"+
							" logra al separar las rectrices externas de la cola, las que con la friccion del aire producen un zumbido inconfundible."
                },
                new AvesBD()
                {
                    id=4,
                    idHabitat = 0,
                    nomAve = "Caiquen",
                    urlSonido="sonidos/caiquen.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Caiquén, avutarda, cauquén, canquén, ganso\n\nDISTRIBUCIÓN EN CHILE:\ndesde Colchagua hasta Tierra del Fuego"+
							" \n\nHABITAT:llanuras y planicies abiertas con pasto\n\nDESCRIPCIÓN:\nMacho:65 - 66 cms. Cabeza y cuello blancos. Manto, pecho,"+
							" abdómen y flancos de color blanco con barras gruesas negras. Lomo, escapulares y primarias gris oscuro. Secundarias blancas."+
							" Plumas centrales de la cola grises oscuras y las laterales blancas. Pico negro. Patas negras.\nEn fase blanca, cabeza, cuello"+
							" y pecho blancos, por lo que también hay fases intermedias en que el pecho está parcialmente manchado con negro.\nHembra: 60 cms."+
							" Cabeza y cuello rojo ladrillo. Dorso y pecho rufo con barras negras. Abdómen y flancos inferiores blancos con barras"+
							" gruesas negras. Lomo y supracaudales negras. Alas igual al macho. Pico negro. Patas amarillas. La hembra de esta especie puede"+
							" ser confundida con el Canquén colorado (Chloëphaga rubidiceps), ya que sus coloraciones son muy similares.",
                    Datos="El Caiquén es el más abundante de los gansos en la zona de Magallanes y Aysén; pero más al norte va bajando su número, encontrándose"+
							" generalmente hasta Colchagua como visitante de invierno, aunque parejas aisladas pueden quedarse durante la época de"+
							" nidificación.\nEn su zona austral, nidifica tanto en zonas bajas como en mesetas y colinas, aprovechando cualquier hoyo"+
							" o depresión cerca de lagunas, rios o esteros y que considere apta para forrarlo con sus propias plumas suaves del pecho,"+
							" formando un nido muy abrigador. La postura generalmente es de 5 a 7 huevos, de dimensiones aproximadas de 75 mm. x 50 mm.,"+
							" y comienza en Noviembre viéndose gansitos entre Diciembre y Febrero, muchos de los cuales caen víctima de aves depredadoras"+
							" como la Gaviota Dominicana (Larus dominicanus) o el Salteador chileno"
                },
                new AvesBD()
                {
                    id=5,
                    idHabitat = 0,
                    nomAve = "Caití",
                    urlSonido="sonidos/caiti.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Caití\n\nDISTRIBUCIÓN EN CHILE:\nzona de la puna, entre Arica y Atacama\n\nHABITAT:\nlagos y lagunas saladas de la"+
							" zona norte cordillerana(puna)\n\n DESCRIPCIÓN:\nLargo: 47 cms.\nPlumaje blanco puro; excepto las alas, cola y parte media"+
							" del dorso que son negras. Pico grisáceo a negro, curvado hacia arriba. Patas grisáceas a negras. Ojos rojos.",
                    Datos="Habita en la zona cordillerana del norte eligiendo exclusivamente para vivir las aguas salinas de esta zona en busca de su"+
							" alimento, como insectos acuáticos o pequeños crustáceos. Su característica más notoria es su pico encorvado hacia"+
							" arriba, que usa a modo de paleta para buscar su alimento.\nAnida en toda su zona de distribución, en nidos rudimentarios"+
							" en el suelo, en champas de vegetación pequeña, y a una distancia de entre 2 a 20 metros del borde del agua. Los huevos,"+
							" similares a los del Perrito son más grandes (50 mm. x 37 mm.) y menos manchados."
                },
                new AvesBD()
                {
                    id=6,
                    idHabitat = 0,
                    nomAve = "Carpintero Negro",
                    urlSonido="sonidos/carpinteronegro.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Carpintero negro, gallo de monte, rere.\n\nDISTRIBUCIÓN EN CHILE:\nTierra del Fuego por el sur hasta"+
							" Llanquihue por la parte costera, y Linares por la zona cordillerana. También en la cordillera de Nahuelbuta.\n\nHABITAT:\nzonas"+
							" de bosque nativo\nDESCRIPCIÓN:\nLargo: 44 - 46 cms.\n\nMacho: \nPlumaje negro con brillos azulados. Cabeza con cresta, garganta"+
							" y cuello totalmente rojos. Dos franjas blancas en el dorso debido a la base de la barba interna de las primarias y la base"+
							" interna de las secundarias de color blanco. Pico negro. Patas negras.\n\nHembra:\n Similar al macho, pero completamente negra"+
							" y sólo las plumas que rodean la base del pico de color rojo.",
                    Datos="Por sus colores y tamaño (casi medio metro de largo), es imposible confundirlo con otra especie. La cresta es un poco más grande"+
							" en la hembra y está compuesta por varias plumas largas satinadas que al erguirse, se doblan hacia adelante.\n"+
							" Su presencia en su hábitat típico, las zonas boscosas, es delatada por un fuerte y penetrante grito, semejante a una carcajada;"+
							" o también por el fuerte martilleo del pico en algún tronco, especialmente si está podrido, cuando busca su alimento consistente"+
							" en gusanos, larvas y otros insectos. \nAnida de preferencia en troncos verticales podridos, en donde taladran con su pico un"+
							" hoyo redondeado y a una altura de unos 15 a 20 mtrs. del suelo. Sus huevos son blancos brillantes, sin manchas ni pintas, de"+
							" cáscara delgada y de un tamaño de 37 mm. x 25 mm. app."
                },
                new AvesBD()
                {
                    id=7,
                    idHabitat = 0,
                    nomAve = "Cernicalo",
                    urlSonido="sonidos/cernicalo.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Cernícalo, llügllüken (araucano)\n\nDISTRIBUCIÓN EN CHILE:\ndesde Atacama hasta Tierra del Fuego\n\nHABITAT:\n"+
							" Campos, praderas y zonas montañosas, desde la costa hasta unos 3.000 metros de altura ( 10.000 fts.) hacia la cordillera."+
							" También se puede observar de vez en cuando en zonas pobladas.\n\nDESCRIPCIÓN:\nLargo: 28 - 30 cms.\n\nMacho adulto: \ncabeza con"+
							" corona azul pizarra oscuro, nuca del mismo color con una mancha rufescente al centro. Manto y lomo café rojizo con estrías"+
							" transversales negras. Garganta, pecho, abdomen y calzones blanco a amarillento sucio con manchitas negras longitudinales."+
							"\nMejillas de igual color que la garganta con linea negra entre el ojo y el cuello y otra entre la zona auricular y el cuello."+
							" Cubiertas alares azul pizarra oscuro con manchas negras. La parte interna igual que el pecho. Cola rojo ladrillo con banda"+
							" subterminal negra y gruesa. Patas amarillas. Pico negro azulado con base amarilla.\n\nHembra adulta:\n similar al macho. Se"+
							" diferencia principalmente por las cubiertas alares de color rojo ladrillo con machas transversales negras; y por la cola sin"+
							"la banda subterminal negra, pero con muchas bandas transversales oscuras y finas.",
                    Datos="El cernícalo es una de las aves más comunes en Chile, y fácilmente diferenciable de otros tipos de halcones por su color rojo"+
							" ladrillo en el manto y lomo. De pequeño tamaño, similar al del tordo o loica, es un ave de rapiña que caza su presa viva. El"+
							" sistema de caza predilecto es al acecho desde un posadero. Le gusta pararse en una rama alta, poste o cualquier cosa en que"+
							" pueda tener una panorámica de su alrededor, vigilante a cualquier animal pequeño que corra cercano; o alguna avecilla que vuele"+
							" en las proximidades. Con un vuelo agil y veloz, también suele detenerse en el aire mientras observa el lugar. Está capacitado"+
							" para vivir en terrenos muy secos y puede pasar largos periodos sin tomar agua. En general, se adapta a cualquier tipo de zona"+
							" excepto el bosque denso. Muy agresivo, no duda en desalojar de su territorio a cualquier otro rapaz que intente invadir su"+
							" territorio, no impotando su tamaño. Con excepción de los periodos de cría, es un ave solitaria.\nPara anidar elige"+
							"huecos en árboles, hoyos en murallas o barrancos, en incluso en entretechos de casas de campo. Sus nidos poseen normalmente"+
							"entre 3 y 5 huevos de color blanco o rojizo pálido y con manchas rojizas grandes y pequeñas"
                },
                new AvesBD()
                {
                    id=8,
                    idHabitat = 0,
                    nomAve = "Chercán",
                    urlSonido="sonidos/chercan.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Chercán\n\nDISTRIBUCIÓN EN CHILE: \ndesde Caldera (Atacama) hasta Cabo de Hornos.\n\nHABITAT:\nEn todos los lugares."+
							" Prados, campos cultivados, dunas costeras, quebradas, faldeos semiáridos de la precordillera, matorrales y zonas pobladas."+
							"\n\nDESCRIPCIÓN:\nLargo: 12 cms.\nCabeza y dorso color canela claro. Garganta, pecho y abdómen blanquesino acanelado. Alas canela"+ 
							" algo rojizas con barras oscuras. Flancos y subcaudales canela rufo. Cola parda algo rojiza con barras transversales negruzcas."+
							" Pico negruzco. Patas café.",
                    Datos="Es una de las aves más comunes del territorio, habitando en casi cualquier lugar de su zona de distribución, desde la costa y"+
							" hasta los 2.500 m.s.n.m. hacia la cordillera. Abarca normalmente desde Coquimbo al sur; sin embargo, durante el invierno emigra"+
							" un poco más al norte pudiéndo encontrársele hasta Caldera.\nPor su pequeño tamaño, su cola levantada y su grito áspero y fuerte,"+
							" se le puede identificar fácilmente, aún mientras de desliza dentro de los tupidos arbustos y matorrales en busca de insectos."+
							"\nCon 2 o 3 posturas al año, busca para anidar un lugar con entrada oscura. Huecos en árboles, cuevas en barrancos e incluso las"+
							"mangas de espantapájaros pueden ser sitios elegidos; por lo que el nido se acomoda al lugar escogido. En una base de palitos o"+
							" pasto y un colchón de plumas, coloca de 4 a 7 huevos de fondo rosado muy manchado con tonos rojos a café oscuro. Tamaños de 17"+
							" mm. x 13 mm. app."
                },
                new AvesBD()
                {
                    id=9,
                    idHabitat = 0,
                    nomAve = "Chincol",
                    urlSonido="sonidos/chincol.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Chincol, copete\n\nDISTRIBUCIÓN EN CHILE:\n desde Atacama a las Islas Guaitecas\nHABITAT: \nCampos, cerros,"+
							" huertos, jardines, plazas. Desde la costa hasta unos 2.000 mts. sobre el nivel del mar.\n\nDESCRIPCIÓN:\nLargo: 14 - 15 cms."+
							" \nMacho: \nCabeza gris con 3 lineas negras a cada lado que parten desde la base del pico hacia la nuca. Una a la altura de la"+
							" corona, otra en la linea de los ojos y la tercera en la linea de la mandíbula inferior. Plumas de la corona levantadas a modo"+
							" de copete. Garganta blanquesina. Gran mancha rufa que rodea el cuello excepto en la linea divisoria entre la garganta y pecho."+
							" Pecho café claro terroso. Abdomen blanquesino. Manto y lomo pardo con lineas longitudinales negras. Cola parda. Patas y pico"+
							" corneos. \nHembra: \nde colores similares, aunque más apagados. Sin las plumas de la corona levantadas\nInmaduro: plumas más"+
							" jaspeadas en el dorso y sin el tono rojizo del cuello; pecho cafe claro terroso muy vermiculado longitudinalmente de café oscuro.",
                    Datos="Semejante al Gorrión(Passer domesticus), aunque un poco más chico y menos macizo, esta ave se distingue principalmente por la gran"+
							" mancha rufescente o rojiza en el cuello. Es una raza típicamente chilena, no encontrándose en ningún otro país.\nAve muy amistosa"+
							" y básicamente insectívora, vive en todos los campos, huertos y jardines desde Atacama hasta las islas Guaitecas (norte de la"+
							" región de Aisén), en donde construye su nido y alegra con su canto característico aunque no muy melodioso, ya que se compone"+
							" de solo cuatro notas que se repiten.  Si bien en el campo sigue siendo numeroso, en la ciudad ha tenido que cederle terreno al"+
							" Gorrión, ave europea traída por primera vez en 1904, y que se propagó con extraordinaria rapidez, primero por toda la zona"+
							" central y actualmente por todo Chile.\nEl nido lo coloca en cualquier arbusto, árbol chico o matorral, a 1 o 2 metros de altura,"+
							" aunque a veces lo hace en el suelo escondido entre el pasto. Para confeccionarlo usa pasto o cualquier sustancia vegetal blanda."+
							" La nidada consta generalmente de 3 huevos de color verde pálido con manchas, pintas o anillos café oscuro o café lila. Rara vez"+
							" se encuentran 4 o 5 huevos en el nido."
                },
                new AvesBD()
                {
                    id=10,
                    idHabitat = 0,
                    nomAve = "Chorlito",
                    urlSonido="sonidos/chorlito.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Chorlito cordillerano, pollito cordillerano, camayo (cordillera de Atacama).\n\nDISTRIBUCIÓN EN CHILE: \nde Arica"+
							" hasta Curicó.\nHABITAT:Lagos, lagunas y bofedales de la zona de la puna\n\nDESCRIPCIÓN:\nLargo: 19 - 20 cms.\nCabeza negra;"+
							" linea blanca que rodea la corona. Cuello en sus zonas trasera y laterales castaño rojizo; delantero negro y pechera blanca."+
							" Dorso, lomo, cubiertas alares y supracaudales pardo grisáceo con tonos bronceados. Pecho blanco muy tupido de lineas finas"+
							" negras transversales; abdómen blanco al centro y con lineas negruzcas menos tupidas hacia los lados. Pico negro. Patas amarillas.",
                    Datos="De costumbre solitaria o en parejas, al Chorlito cordillerano se le encuentra en la cordillera de Los Andes a alturas entre los"+
							" 3.000 y 5.000 m.s.n.m. en la zona norte; y entre los 2.000 y 3.000 m.s.n.m. hacia la zona central, en las lagunas, riachuelos"+
							" y zonas húmedas. Ave migratoria, se le comienza a ver alrededor del mes de Octubre a medianas alturas, para posteriormente"+
							" subir a unos 3.000 metros para anidar y quedarse hasta los meses de Abril y Mayo cuando se retira en dirección norte. Camina"+
							" callado y sigilosamente sobre piedras y rocas húmedas, buscando los insectos acuáticos escondidos entre las algas y que"+
							" conforman su alimentación. Bastante confiado a la presencia humana, vuela tardíamente, con un vuelo fuerte y rápido; sin embargo,"+
							" su mimetismo con el medio es tan bueno que normalmente pasa inadvertido.\nAnida cerca del agua en una depresión en el pasto, en donde"+
							" coloca unos huevos bastante parecidos a los del Queltehue, aunque más chicos; y de tamaño de 37 x 26 mm. app."
                },
                new AvesBD()
                {
                    id=11,
                    idHabitat = 0,
                    nomAve = "Choroy",
                    urlSonido="sonidos/choroy.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Choroy\n\nDISTRIBUCION EN CHILE:\nEndémico. Aconcagua a Chiloé y rara vez hasta Aysén\n\nHABITAT:\nPrincipalmente"+
							" en bosques de Nothofagus y Araucaria. En bosques esclerofilos hacia la zona central. Hasta los 2.000 m.s.n.m.\n\nDESCRIPCION:\n"+
							"Largo: 40 - 42 cms.\nSin dimorfismo sexual. Coloración general verde a verde oscura. Corona con ribetes transversales negros."+
							" Mancha rojiza entre la frente y lorums (zona delantera de los ojos). Anillo desnudo rodeando el ojo. Abdómen con mancha rojiza"+
							" poco notoria. Primarias con barba interna azulina. Cola roja oscura con punta verdosa. Pico gris oscuro, grueso con mandíbula"+
							"superior larga y ganchuda. Patas rosadas pálidas.\n\nALIMENTACION:\nSemillas y frutos; especialmente los piñones (frutos) de la"+
							" Araucaria.\n\nREPRODUCCION:\nAnida en huecos de árboles, y a una distancia apreciable del suelo. Coloca de 3 a 6 huevos blancos,"+
							" opacos y algo redondeados; tamaño promedio: 34 x 27 mm. app.",
                    Datos="OBSERVACIONES:\nVive unicamente en Chile, eligiendo principalmente los grandes bosques de la zona sur. Muy sociable y bullicioso,"+
							" suele vérsele en grandes bandadas durante todo el año, ya sea entre las ramas de los árboles o en el suelo mientras busca su"+
							" alimento, manteniendo una algarabía a veces increible. Mientras la bandada come, centinelas ubicados en las ramas vigilan por"+
							" si algún intruso se les acerca.\nPosible confusion con la Cachaña(Enicognathus ferrugineus), la cual es algo mas pequeña"+
							" y tiene la maxila (mandibula superior) mas corta.\nTambien citado para Argentina (Fjeldsa & Krabbe, 1990), esto se debe a un"+
							" error tipografico (Mazar & Pearman, 2001) (Martinez & Gonzalez, 2004)"
                },
                new AvesBD()
                {
                    id=12,
                    idHabitat = 0,
                    nomAve = "Chucao",
                    urlSonido="sonidos/chucao.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Chucao, tricao.\n\nDISTRIBUCIóN EN CHILE:\ndesde el sur de Colchagua hasta Aysén.\n\nHABITAT:bosques y selvas"+
							" de la zona sur\n\nDESCRIPCIÓN:\nLargo: 18 cms.\nCabeza gris apizarrada, con linea rufescente que cruza el ojo. Manto y lomo"+
							" gris-rojizo. Garganta y pecho superior rufo. Pecho gris con lineas transversales finas blancas y negras. Abdómen gris. Cola"+
							" rufa con negro. Alas negro pizarra con tinte rufescente por encima. Pico negro. Patas negras.",
                    Datos="Ave característica de la selva y bosques de la zona sur y abundante entre Valdivia y Chiloé. Fácil reconocerlo por el tono"+
							" rojizo de su garganta y pecho; aunque tiene hábitos recluidos y sigilosos, que lo hacen mantenerse generalmente dentro de"+
							" las espesuras de los bosques. Le gusta la cercanía de algún estero o riachuelo, por lo que es más fácil verlo en los momentos"+
							" en que baja a tomar agua,  y siempre que crea estar solo.\nAnida cuando el terreno aún está húmedo y fangoso por las lluvias"+
							" invernales, en una cueva que cava en el suelo, en algún barranco o ladera escarpada con mucha vegetación. Pone de 2 a 3 huevos"+
							" blancos, bastante grandes en relación al tamaño del ave,  de dimensiones de 28 mm. x 23 mm. app."
                },
                new AvesBD()
                {
                    id=13,
                    idHabitat = 0,
                    nomAve = "Chuncho",
                    urlSonido="sonidos/chuncho.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Chuncho, chucho\n\nDISTRIBUCIÓN EN CHILE:\nAtacama a Tierra del Fuego\n\nHABITAT:\nLlanuras de la costa y"+
							" del Valle Central; hacia la cordillera hasta los 2.000 m.s.n.m. A veces en las ciudades, en jardines y parques.\nDESCRIPCIÓN:"+
							"\nLargo: 20 - 21 cms.\nCabeza, dorso y cobertoras gris pardo con algo de castaño, y manchitas claras a blancas. Garganta blanca."+
							" Linea superciliar blanca que baja hacia los lorums. Pecho y abdómen con rayas gruesas longitudinales blanquesinas, pardas y"+
							" negruzcas. Dibujo similar a un collar en la nuca a veces poco visible, de pecas blancas con negro o a veces solo negro. Cola"+
							" con bandas tranversales negruzcas y castañas. Pico corto ganchudo, oscuro en su base y punta amarillenta. Patas amarillas."+
							" Ojos grandes amarillos.",
                    Datos="Aunque de costumbres más diurnas que otras aves de su tipo, el Chuncho es difícil de ver. Su pequeño tamaño, su vuelo silencioso"+
							" y su inmovilidad en la rama donde se posa lo hacen pasar inadvertido. Algo común en las zonas centro y sur, se le encuentra"+
							" desde la costa hasta unos 2.000 m.s.n.m. hacia la cordillera; incluidos los jardines y plazas de las ciudades. En cambio,"+ 
							" hacia la zona norte suele ser escaso, siendo más bien un visitante de invierno.\nSe alimenta de aves, insectos, mamíferos y"+
							" reptiles. Agresivo y feroz, caza animales incluso más grandes que él, matándolos rápidamente con sus pequeñas pero poderosas"+
							" garras.\nAnida entre Septiembre y Noviembre, en huecos de árboles; colocando de 3 a 5 huevos blancos, opacos y bastante"+
							" redondeados (30 mm. x 25 mm. app)."
                },
                new AvesBD()
                {
                    id=14,
                    idHabitat = 0,
                    nomAve = "Churrin",
                    urlSonido="sonidos/churrin.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Tutita.\n\nDISTRIBUCIÓN EN CHILE:\ndesde Maule a Chiloé; y en la Isla Mocha\n\nHABITAT:\nzonas boscosas y"+
							" densamente vegetadas.\n\nDESCRIPCIÓN:\nLargo: 15 - 16 cms.\nPor encima, el plumaje es de un tono griz oscuro apizarrado;"+
							"lomo y supracaudales café rufo con leve tinte amarillento. Pecho gris apizarrado más claro que el dorso, especialmente"+
							" hacia las partes centrales. Abdomen, flancos y subcaudales rojizo claro con tinte amarillento hacia el abdomen. Alas del mismo"+
							" tono del dorso. Pico negro. Patas córneas.",
                    Datos="El Churrín de la Mocha, tanto en su aspecto como en sus costumbres representa un término medio entre las Turcas y Hued-hued por"+
							" una parte; y los Churrines por la otra. Esto hizo que a los ornitólogos se les presentara un gran problema al tratar de"+
							" clasificarlo. Por este motivo, dentro de los Rhinocryptidae, crearon un género nuevo especialmente para incluir al Churrín de"+
							" la Mocha como su único representante: el género Eugralla.\nAunque por el nombre de Churrín de la Mocha da la impresión de ser"+
							" una especie endémica de aquella isla, no es así, ya que también se encuentra en el continente, en todas las zonas boscosas"+
							" desde el sur del Maule hasta Llanquihue e isla de Chiloé. Sin embargo, en la Isla Mocha es muy abundante.\nDurante el invierno"+
							" de 1957 en Santo Domingo (paralelo similar al de Santiago), A. W. Johnson escuchó en una espesura aislada, y luego vio a un"+
							" Churrín de la Mocha que huyó rápidamente. Es el registro más norteño para esta ave aunque fue un caso aislado.\nSimilar al"+
							" Churrín (Scytalopus fuscus), pero de tamaño notablemente más grande, se le encuentra entre la espesura de los grandes bosques"+
							" en donde camina por el suelo, rascándolo en busca de alimento de forma semejante a como lo hace una gallina, siendo incluso"+
							" posible escucharlo. En cambio su andar es silencioso y debido a su plumaje gris oscuro, es fácil confundirlo a primera vista"+
							" con algún ratoncillo. Su grito más común es un ruido áspero similar a &quot;Chek-chek-chek&quot; extremadamente repetitivo.\n"+
							"De hábitos más arbóreos que los otros miembros de su familia, construye un gran nido, del tamaño de la cabeza de un hombre,"+
							" colocándolo entre 1 y 2 metros de altura, hechos con palitos y pasto seco y con la entrada de unos 40 mms. de diámetro por"+
							" un lado. La nidada suele ser de 2 a 3 huevos blancos y algo brillosos, de tamaño promedio de 24 x 19 mms.; y dos posturas"+
							" al año, normalmente en Septiembre y luego a fines de Noviembre.\nUn nido encontrado por D. S. Bullock estaba a 7 metros de"+
							"altura en la rama horizontal de un árbol."
                },
                new AvesBD()
                {
                    id=15,
                    idHabitat = 0,
                    nomAve = "Cisne Coscoroba",
                    urlSonido="sonidos/cisne_coscoroba.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Coscoroba, cisne blanco \n\nDISTRIBUCIÓN EN CHILE:\n Residente entre Puerto Montt y Cabo de "+
					"Hornos (X a XII regiones). Como aves migratoria hacia el norte hasta Huasco (IV region). \n\nHABITAT:\n Lagos, lagunas, canales, "+
					"pantanos. \n\nDESCRIPCIÓN:\n Largo: 112 cms. Totalmente blanco. Primarias con punta negra. Pico rojo con punta rosada. "+
					"Patas rosadas. Ojos rojos.",
                    Datos="El Cisne Coscoroba no puede ser confundido con ninguna otra ave, debido a su forma tópica de cisne y su color enteramente"+ 
					"blanco, excepto las puntas de las alas que son negras. Es ave residente principalmente desde la latitud 44ºS al Cabo de Hornos y "+
					"en las islas Malvinas (Falklands). Pero en invierno, es posible ver desplazamientos en pequeños números hacia el norte, alcanzando "+
					"hasta la parte sur de Brasil. \nEn Chile, en estos desplazamientos hacia el norte pueden llegar hasta Valdivia, y ocasionalmente "+
					"hasta la región de Valparaíso; siendo el registro más norteño, Huasco (C. Tala, 1997). \nViven en pequeños grupos en lagos, lagunas, "+
					"canales, zonas pantanosas y senos, siendo posible verlos cerca de canquenes (Chloëphaga poliocephala), caiquenes "+
					"(Chloëphaga picta), patos-quetru (Tachyeres sp.), cisnes de cuello negro (Cygnus melancoryphus) y otros. \nSu alimentación "+
					"consiste en invertebrados acuáticos, huevos de pescados y materia vegetal. \nAnidan entre los meses de Octubre y Diciembre, sobre "+
					"los pastos altos de las lagunas, pasto, bordes de agua y preferentemente sobre islas pequeñas de vegetación flotante; colocando entre "+
					"4 y 6 huevos de color blanco sucio, y un tama&ntilde;o promedio de 89 x 60 mms. app. Los polluelos son nidífugos."
                },
                new AvesBD()
                {
                    id=16,
                    idHabitat = 0,
                    nomAve = "Cisne cuello negro",
                    urlSonido="sonidos/cisne_cuello_negro.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Cisne \n\nDISTRIBUCION EN CHILE:\n Coquimbo al Cabo de Hornos. Accidental en Atacama y en la isla Robinson "+
					"Crusoe. \n\nHABITAT:\n Agua dulce y salada de lagos, lagunas, canales, desembocadura de rios. En general aguas tranquilas y protegidas, "+
					"con poca o sin corriente, de poca profundidad, que permitan el crecimiento de vegetales sumergidos. Hasta unos 1.200 msnm."+
					"\nDESCRIPCION: Largo: 122 cms. Peso: 6.5 kg. (macho); 4.5 kg. (hembra) Ambos sexos iguales. Cabeza y cuello negros; resto blanco. "+
					"Linea blanca que rodea el ojo hasta las auriculares. Pico gris con gran carúncula roja. Patas rosadas. \n\nALIMENTACION:\n Se alimenta "+
					"preferentemente de vegetales, los que obtiene sumergiendo la cabeza o hasta medio cuerpo para alcanzarlos. Hay referencias de aves "+
					"que han salido a buscar comida en praderas. También come moluscos, insectos acuáticos y sus larvas y huevos de peces. \nREPRODUCCION: "+
					"Su epoca de reproducción ve desde mediados de Octubre a fines de Noviembre, anidando en pajonales tupidos al borde de las lagunas o en "+
					"islotes alejados de las riberas. El nido es voluminoso hecho de juncos y pastos. Coloca de 4 a 7 huevos de color blanco sucio y "+
					"dimensiones de 101 mm. x 66 mm. app. Aunque es un ave pacífica, durante la época de reproducción el macho se vuelve agresivo atacando "+
					"a quién quiera acercarse.",
                    Datos="OBSERVACIONES: Ave endémica de Sudamerica, se le encuentra desde el sur de Brasil, Paraguay, Uruguay, Argentina y Chile hasta "+
					"Tierra del Fuego, Canal Beagle e islas Falkland (Malvinas). Es la mayor de las aves acuáticas del país. Fácilmente reconocible por su "+
					"tamaño y colores. Necesita un espacio grande para levantar vuelo, pero una vez en el aire es capaz de volar grandes distancias. Incluso "+
					"ha llegado a la isla Robinson Crusoe del Archipiélago de Juan Fernández, situada a 670 kms. del continente. \nDe costumbres gregarias, "+
					"forman grupos dentro de los cuales se mantienen individuos emparentados, muy posiblemente durante toda su vida. Se agrupa en grandes "+
					"bandadas dispersas en ciertos sitios de nidificación. Son frecuentes los combates territoriales, luego de los cuales los integrantes "+
					"de la pareja emiten voces rápidas, moviendo las cabezas hacia arriba y hacia abajo."
                },
                new AvesBD()
                {
                    id=17,
                    idHabitat = 0,
                    nomAve = "Codorniz",
                    urlSonido="sonidos/codorniz.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Codorniz, chancaca, tococo \n\nDISTRIBUCION EN CHILE:\n Atacama a Valdivia. Preferentemente en la zona central, "+
					"entre Coquimbo y Concepcion. Registros en San Pedro de Atacama y en los alrededores del lago General Carrera. Introducida tambien en la "+
					"isla Robinson Crusoe, hoy extinta. \n\nHABITAT:\n Campos y quebradas con vegetacion de matorral. Zonas semiaridas. \n\nDESCRIPCION:\n Largo: "+
					"24 - 27 cms. Envergadura: 32 - 37 cms. Peso: 140 - 230 grms. \nMacho: Frente blanquesina. Corona cafe separada de la frente por lineas "+
					"negra y blanca y copete de plumas anchas negras dobladas hacia adelante. Garganta y cuello delantero negro bordeada por una linea ancha "+
					"blanca hasta las auriculares. Cuello trasero con pequeñas plumas blanquesinas bordeadas de negro. Dorso, supracaudales y "+
					"cobertoras gris tierra. Pecho gris. Abdomen con plumas amarillas bordeadas de negro. Centro del abdomen con plumas rufas bordeadas de "+
					"negro. Flancos gris tierra con lineas longitudinales blancas. Subcaudales cafe claro con linea central pardo oscuro. Alas redondeadas. "+
					"Primarias gris tierra. Secundarias gris tierra con finos bordes blanquesinos. Pico negro. Patas grisaceas. \nHembra: algo mas "+
					"pequeña y mas cafe. Cabeza cafe; sin el negro y blanco del macho; copete negro mas corto y delgado. Plumas del abdomen amarillo "+
					"palido. \n\nALIMENTACION:\n La dieta es un 70% vegetariana, alimentandose principalmente de semillas, ademas de hojas, bayas y granos. "+
					"Tambien come invertebrados como orugas, escarabajos, acaros y pequeños, caracoles, los que buscan rasguñando el suelo con "+
					"sus patas. \n\nREPRODUCCION:\n Anida en el suelo, entre pastos y malezas; arma una depresion de 12 - 18 cms., y profundidad de 3 - 5 cms, "+
					"forrandolo con tallos, pastos y algunas plumas. Ponen de 8 a 18 huevos blancos muy manchados con diversos tonos de cafe, y tamaño "+
					"de 32 mm. x 25 mm. app. A veces 2 o mas hembras pueden colocar sus huevos en el mismo nido. Los polluelos son nidifugos, corriendo por "+
					"todas partes poco tiempo despues de nacer.",
                    Datos="OBSERVACIONES: Ave originaria de California, Estados Unidos.  Goodall et al. (1951) indican que algunas parejas fueron traidas "+
					"a Chile en el año 1870. Se aclimataron en tan buena forma que hoy es un ave tipica de los campos y quebradas chilenas en su zona de "+
					"distribucion. Muy abundante en la zona central de Chile, su perfecta aclimatacion al territorio se puede ver en el aumento en los rangos "+
					"de distribucion dados por la literatura a medida que pasa el tiempo. \nGoodall, Johnson y Phillippi (1951) la localizan entre Coquimbo y "+
					"Concepcion (entre 4 y 8 regiones). Araya y Millie (1998) amplian su rango entre las regiones de Atacama y Araucania (entre 3 y 9 regiones). "+
					"Y hoy hay registros en San Pedro de Atacama, Valdivia y en los alrededores del lago General Carrera. Introducida tambien en la isla de "+
					"Robinson Crusoe alrededor de 1912, hoy se encuentra inexistente. \nDos grandes caracteristicas identificatorias para esta ave son las "+
					"grandes plumas negras sobre la cabeza, en forma de coma en el macho, y un penacho mas pequeño en la hembra; y el grito fuerte y "+
					"penetrante similar a 'CHAN-CA-CA' que usan como llamado para localizarse y que puede ser escuchado de un cerro a otro. \nMuy esquiva y "+
					"buena corredora, prefiere huir corriendo. Rara vez se aleja de la zona de matorrales hacia campo abierto. Su vuelo agil y rapido a ras "+
					"de la vegetacion le permite desaparecer con gran facilidad; y en picada bajando una quebrada o loma puede alcanzar una velocidad "+
					"increible. Prefiere las zonas secas a los campos humedos."
                },
                new AvesBD()
                {
                    id=18,
                    idHabitat = 1,
                    nomAve = "Comesebo tamarugal",
                    urlSonido="sonidos/comesebo_tamarugal.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): ---- \n\nDISTRIBUCIÓN EN CHILE: \nExtremo norte (Pampa del Tamarugal. Salar de Pintados; Salar de Zapiga. Pica y "+
					"Mamiña). \nHABITAT: Bosque de Tamarugos y laderas semi-vegetadas de la zona desértica. \n\nDESCRIPCIÓN: \nLargo: 11 - 12 cms. Corona, "+
					"nuca, cuello trasero, dorso y lomo gris apizarrado. Lineas superciliares rufas desde la zona auricular, juntándose en la frente. Mejillas "+
					"blanquesinas barrada de tono oscuro. Garganta y pechera rufa; Resto del pecho y abdomen gris pálido, abdomen con leve tinte amarillento. "+
					"Subcaudales rufas. Alas pardo grisáceo con mancha blanca. Cola pardo grisáceo. Pico y patas oscuras.",
                    Datos="Pampa del Tamarugal es un amplio sector en la parte centro-sur del desierto de Tarapacá y norte del desierto en Antofagasta, que se "+
					"encuentra poblada en gran cantidad por la especie vegetal Tamarugo (Prosopis tamarugo), arbusto muy resistente a las zonas extremadamente "+
					"secas que caracterizan a este desierto. El Comesebo de los tamarugales es un ave característica de esta zona, el cual es capaz de vivir en "+
					"un ambiente tan inóspito como éste."
                },
                new AvesBD()
                {
                    id=19,
                    idHabitat = 1,
                    nomAve = "Cometocino del Norte",
                    urlSonido="sonidos/cometocino_norte.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): ---- \n\nDISTRIBUCIÓN EN CHILE:\n Zonas cordilleranas desde el extremo norte hasta Baños del Toro (Coquimbo). "+
					"\n\nHABITAT: \nZonas vegetadas entre los 2.500 y 4.500 m.s.n.m. \n\nDESCRIPCIÓN:\n Largo: 17 cms. \nMacho:\n Cabeza, cuello y pecho superior "+
					"negros. Dorso amarillo acanelado aclarando a amarillo hacia el lomo. Supracaudales negruzcas. Pecho inferior amarillo acanelado; abdomen "+
					"y flancos amarillos; centro del abdomen amarillo con leve tinte verdoso (azufrado). Subcaudales blanquesinas. Alas y cola negruzcas con "+
					"plumas bordeadas de gris claro a blanquesino. Pico córneo. \nHembra: \nCabeza y cuello gris laucha con plumas rayadas de negro; mejillas y "+
					"garganta negruzcas. Dorso café oliváceo pasando a oliváceo hacia el lomo. Pecho amarillo con tono anaranjando; abdomen y subcaudales "+
					"blanquesino.",
                    Datos="Por el tamaño y la forma de distribución de sus colores, se creyó en un principio que esta ave correspondía a una subespecie del "+
					"Cometocino de Gay (Phrygilus gayi gayi); sin embargo, observaciones posteriores demostraron que debía ser considerada una especie "+
					"distinta. \nSe le encuentra en las zonas cordilleranas desde el extremo norte hasta Baños del Toro, en Coquimbo, siempre por sobre los "+
					"2.500 m.s.n.m. Por sus colores, el macho es fácil de identificar; en cambio la hembra puede ser confundida con el Cometocino de Gay, por "+
					"su gran parecido. Además, tanto sus costumbres como sus cantos son similares; mostrando eso sí, el Cometocino del norte, una mayor "+
					"variedad en los sitios que usa para anidar. \nEl nido está muy bien construído, a base de tallos de pasto seco y forrado de pastos "+
					"más finos, lana o crín. Pueden estar escondidos a ras de suelo entre el pasto alto, en algún arbusto tupido, en un altero de alguna "+
					"choza u otro lugar que le proporcione seguridad. Los huevos son de tono verde azulado claro manchado abundantemente con pintas café a "+
					"púrpuras, más cargadas hacia el lado obtuso, siendo muy similares en su aspecto a los huevos de Cometocino patagónico (Phrygilus "+
					"patagonicus), Cometocino de Gay (Phrygilus gayi) o del Pájaro plomo (Phrygilus unicolor), pero de un tamaño notoriamente más grande "+
					"(23 x 16 mms. promedio)."
                },
                new AvesBD()
                {
                    id=20,
                    idHabitat = 0,
                    nomAve = "Cometocino Patagonico",
                    urlSonido="sonidos/cometocino_patagonico.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Cometocino, chanchito, quichan \n\nDISTRIBUCIÓN EN CHILE: \ndesde La Serena a Tierra del Fuego \n\nHABITAT:\n "+
					"laderas y quebradas muy vegetadas con arbustos semilleros y salientes rocosas \n\nDESCRIPCIÓN: \nLargo: 15 - 16  cms.\nMacho: \nCabeza, "+
					"cuello y parte superior del pecho gris azulado oscuro, similar a un capuchón. Alrededor del pico y lorums negruzco. Dorso amarillo "+
					"olivaceo con tonos castaños en la mayoria de los ejemplares. Lomo amarillento. Pecho y abdomen amarillo verdoso. Subcaudales gris "+
					"azuloso palido. Primarias negruzcas. Cobertoras y cola gris azulado oscuro. \nHembra:\n Los tonos azulados oscuros de la cabeza, "+
					"cobertoras y cola del macho cambian a grisáceo. Dorso verde olivaceo oscuro. Partes inferiores verde amarillento pálido; subcaudales "+
					"gris pálido.",
                    Datos="Se le encuentra desde la zona costera hasta unos 1.800 m.s.n.m.; y preferentemente en la zona sur desde Curicó hasta Tierra del "+
					"Fuego en donde anida, subiendo hacia la zona central para llegar a la región de Valparaíso y con registros hasta La Serena (Jorge et "+
					"al. 1998, Martinez y Gonzalez, 2004) durante el invierno. Gusta frecuentar las laderas de quebradas muy vegetadas, especialmente las "+
					"que tienen arbustos semilleros, o con salientes rocosas cubiertas de matorrales de lianas. \nPor su tamaño y colores puede ser "+
					"confundido en el medio con el macho del Cometocino de Gay> (Phrygilus gayi), aunque los tonos grises de la cabeza, cobertoras y cola "+
					"son marcadamente más oscuros que los del P. gayi; además de su dorso con tinte anaranjado. Linea malar mas notoria. \nDebido a su "+
					"gusto por el habitat de vegetación densa, es difícil localizar sus nidos, los que generalmente son colocados muy cerca de las raices "+
					"o dedritus vegetal cerca de barrancos. El nido es de tipo taza, construido con material vegetal blanco y forrado con crin de caballo "+
					"u otro material suave. La nidada consta de entre 2 a 4 huevos de tono verde pálido con abundantes manchitas y pintas gris-violáceas "+
					"a pardo-violáceas, agrupándose hacia el polo más ancho del huevo. Tamaño promedio de 20 x 15,5 cms. app."
                },
                new AvesBD()
                {
                    id=21,
                    idHabitat = 0,
                    nomAve = "Concon",
                    urlSonido="sonidos/concon.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Concón \n\nDISTRIBUCIÓN EN CHILE: \ndesde Santiago a Tierra del Fuego \n\nHABITAT:\n Bosques y selvas "+
					"\n\nDESCRIPCIÓN: \nLargo: 38 cms. Cabeza negra. Cara con disco facial café bordeado de negro. Dorso negro pardusco con estrías "+
					"transversales amarillento suave. Garganta blanquesina; collar acanelado en el cuello. Pecho similar al dorso, pero de tono más "+
					"claro, y aclarando más hacia el abdomen en donde las barras son de color blanco sucio. Primarias, flancos, subalares y cola acaneladas. "+
					"Patas con calzones ocres. Ojos pardos. \n",
                    Datos="El Concón es una especie de hábitos totalmente nocturnos. Vive en las zonas de bosques y "+
					"selvas por lo que más abundante hacia la zona sur y bastante escaso desde el Biobio hasta Santiago, su límite norte. \nCon un canto "+
					"menos sonoro y más largo que el del Tucúquere (Bubo magellanicus), es el representante en Sudamérica del Tawny owl europeo, o del "+
					"Barred owl norteamericano. \nSe alimenta de mamíferos pequeños, cazando gran cantidad de lauchas y ratones. Anida en huecos de árboles "+
					"en plena selva, colocando huevos de tamaño promedio de 42 x 32 mms."
                },
                new AvesBD()
                {
                    id=22,
                    idHabitat = 0,
                    nomAve = "Condor",
                    urlSonido="sonidos/condor_andes.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Cóndor, buitre \n\nDISTRIBUCIÓN EN CHILE: \nen todo el país \n\nHABITAT: \na lo largo de toda la Cordillera de "+
					"Los Andes; llegando hasta las costas en la zona norte y en el extremo sur del país. \n\nDESCRIPCIÓN: \nLargo: 100 - 120 cms. Envergadura: "+
					"280 - 320 cms. Peso: 8 - 15 kgrms. \nMacho:\n Cabeza y cuello desnudos de color rojizo oscuro. Sobre el pico y la frente gran cresta del "+
					"mismo color de la cabeza, que baja por ambos lados del pico en forma de pellejo colgante. Collar de plumas blancas en la base del cuello. "+
					"Todo el cuerpo cubierto con plumas negras con algunos brillos metálicos. Cubiertas alares con faja blanca dividida por linea negra. "+
					"Primarias negras. Secundarias negras con barba externa blanca. Pico grueso ganchudo, mitad basal carnosa, mitad externa color hueso. Patas "+
					"cafe apizarradas. Ojos marrón. \nHembra:\n más pequeñas que el macho, sin la cresta, con ojos rojos. \nInmaduros: de color pardo grisáceo con "+
					"la cabeza y cuello negruzcos. \n\nALIMENTACION:\n Basicamente carne descompuesta (carroña). A veces opta por animales moribundos, recien nacidos "+
					"o huevos de otras aves, cuando la carroña escasea. \n\nREPRODUCCION: \nCortejo nupcial cada dos años, manifestándose por danzas en tierra, entre "+
					"los meses de Agosto y Septiembre. Anida en grietas o cuevas de acantilados depositando un huevo, blanco sin manchas sobre la roca o arenisca "+
					"del lugar. Este es ovalado, con medidas promedio de 114 x 70 mms. Tiempo de incubacion entre 54 y 65 dias. Tanto el macho como la hembra "+
					"cuidan la cria, la cual se queda en el nido de 6 a 8 meses, separandose de sus padres entre los 5 y 8 años.",
                    Datos="OBSERVACIONES: Se puede decir que es el ave simbolo de la Cordillera de Los Andes. Habita en las grandes alturas de esta gran "+
					"cadena montañosa desde Venezuela y Colombia por el norte, hasta los ultimos rincones de Tierra del Fuego por el sur. Sin embargo, tanto "+
					"en Peru y la zona norte de Chile como en el extremo sur del continente, es posible verlo llegar hasta la costa. \nEs el ave voladora mas "+
					"grande, lo que la distingue facilmente tanto en tierra como en vuelo; ademas de su caracteristico collar de plumas blancas. Excelente "+
					"voladora, sabe aprovechar a la perfeccion las corrientes de aire ascendente, pudiendo tener interminables planeos que le permiten cruzar "+
					"valles y montañas sin mover sus alas. \nMuy rara vez ataca a animales vivos (y de hacerlo elige a los recien nacidos, enfermos o "+
					"moribundos) debido a que se alimenta principalmente de carroña, animales y peces muertos que logra ubicar desde las alturas debido a su "+
					"vista extraordinariamente aguda. Una caracteristica es que al no ser un ave cazadora, como el aguila, aguilucho o halcon, no posee las "+
					"tipicas patas de estos, con dedo trasero desarrollado y prensil y u&ntilde;as curvas, largas y puntiagudas; sino que las uñas son romas "+
					"y poco curvadas y el dedo trasero poco desarrollado y a diferente plano con respecto a los dedos delanteros, siendo sus patas mas "+
					"similares a las patas de las gallinas. Por este motivo, el Condor no puede tomar a  la presa y llevarla a un lugar mas seguro para "+
					"alimentarse, por lo que debe comer en el mismo lugar en donde encontro al animal muerto. En su gran buche, que le permite transportar "+
					"hasta 4 kgms. de alimentos, le lleva la comida a su cria en el nido. Muchas veces come tanto que le es dificil levantar vuelo por el "+
					"exceso de peso y otras veces simplemente no puede hacerlo y debe reposar un rato. \nEste hecho ya conocido en los tiempos de la colonia, "+
					"lo usaban a su favor los campesinos y arrieros, quienes pensaban erroneamente que los condores mataban a su ganado. Impedian que volaran "+
					"matando a un animal herido o viejo y esperando a que estas aves se lo comieran entero. Luego, al no poder volar los mataban a golpes de "+
					"palos. Conocida es la  lamina historica 23, del Tomo 1 de la obra 'Historia Fisica y Politica de Chile' de Claudio Gay (1854), en que "+
					"justamente aparece una caza de condores de esta manera. \nOtra caracteristica de los condores es su pico ganchudo, grande y muy fuerte, "+
					"que le permite romper el duro cuero de animales como vacas, guanacos y llamas, y triturar sus huesos. Debido a esto, otras carroñeras "+
					"menores como los traros, caranchos y jotes, esperan la llegada de condores para que lo rompan o desgarren y poder alimentarse, aunque "+
					"para ello deban esperar que los condores terminen de alimentarse o puedan arrebatarles algun pedazo de carroña. Interesante tambien es "+
					"la jerarquia en cuanto a la alimentacion del condor: primero comen los machos adultos, luego las hembras adultas y al final los jovenes. "+
					"Justamente por volar a grandes alturas a traves de las altas montañas de la cordillera, es que elige estos lugares para anidar, pasar "+
					"las noches o las tormentas, buscando alguna grieta, caverna o cueva profunda. \nQueda clara la función biologica de esta especie en el "+
					"ecosistema, junto a las otras de la familia Cathartidae, ya que incluso esta palabra viene del griego 'Kathartes' que significa 'el que "+
					"limpia'."
                },
                new AvesBD()
                {
                    id=23,
                    idHabitat = 0,
                    nomAve = "Cotorra",
                    urlSonido="sonidos/cotorra.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):-----\n\nDISTRIBUCIóN EN CHILE:\nRegistros entre Iquique y Puerto Montt.\n\nHABITAT:\nZonas de arboles altos\n"+
							"DESCRIPCIÓN:\nLargo: 30 cms.\nCorona, auriculares, cuello trasero, dorso, cobertoras y supracaudales de color verde claro."+
							" Frente, garganta, mejillas, cuello delantero y partes inferiores blanco sucio a grisáceo; subcaudales verde amarillento."+
							" Rémiges azuladas. Cola verde. Pico ancho y macizo de tono hueso rosado.\n\nSi bien esta especie no era un ave silvestre"+
							" chilena, sus colores y en especial su capacidad para articular y recordar palabras y frases, la convertió en un ave requerida"+
							" como mascota. Sin embargo, debido a ejemplares escapados de jaulas, ya es frecuente ver en algunas ciudades entre Iquique y"+
							" Puerto Montt, ejemplares libres o colonias reproductivas.\nPara anidar elige lugares altos por sobre los 6 metros, en postes"+
							" metálicos, en donde puedan armar sus voluminosos nidos; o en árboles, notándose una marcada preferencia por la Araucaria"+
							" brasileña, eucaliptus y palmeras.\nEsta especie, junto al Gorrión(Passer domesticus), son consideradas como dañinas por el"+
							" Servicio Agrícola y Ganadero (SAG).",
                    Datos="La cotorra argentina es un ave que se encuentra distribuída en la zona central de América del Sur. La especie típica Myiopsitta"+
							" monachus monachus habita en la parte sur-este de Brasil, Uruguay y Norte de Argentina. Además se encuentran las subespecies M."+
							" m. calita al sur y oeste de Argentina; M. m. cotorra al norte de Argentina, sur de Brasil, este de Bolivia y Paraguay; y M. m."+
							" luchsi, una población aislada en Bolivia, que es más pequeña y con distintos hábitos de nidificación (podría ser incluso una"+
							" especie distinta de loros).\nA diferencia de las demás especies de loros que anidan en cuevas o cavernas montañosas o de"+
							" acantilados, la Cotorra argentina anida en árboles altos como por ejemplo eucaliptus, o torres eléctricas (excepto la subespecie"+
							" M. m. luchsi que lo hace en cuevas) contruyendo su nido con ramas entrelazadas y generalmente por sobre los 10 mts. de altura."+
							" Sube por los troncos usando sus fuertes uñas y ayudándose con su pico el cual usa como una eficaz herramienta complementaria."+
							" Otras veces usa un nido en deshuso, el cual acomoda para sí. Estos nidos pueden ser pequeños, alojando a una pareja; o"+
							" comunitarios, es decir alojando a varias parejas por lo que pueden llegar a medir un metro de diámetro y pesar 200 kg.\nVuela"+
							" generalmente en grupos de 15 o 20 ejemplares, aunque es posible verlo en bandadas de 100. Se alimenta principalmente de granos,"+
							" tanto silvestres como cultivados. Dentro de estos últimos, está el sorgo, maiz y arroz. Por este motivo, en 1935 en Argentina,"+
							" fue declarado plaga.\nSe adapta fácilmente a las altas y bajas temperaturas. Esto le ha permitido poblar zonas distintas a las de"+
							"su habitat, como es el caso en Estados Unidos, que a pesar del trabajo realizado por la USFWS en los años '70 para erradicar a"+
							"esta especie, no lo logró.\n"
                },
                new AvesBD()
                {
                    id=24,
                    idHabitat = 0,
                    nomAve = "Diuca",
                    urlSonido="sonidos/diuca.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Diuca\n\nDISTRIBUCIóN EN CHILE:\nCoquimbo a Magallanes.\nIntroducida en Isla de Pascua.\n\nHABITAT:\nvive tanto en"+
							" los jardines y plazas de las ciudades, como en los matorrales, quebradas y praderas de los campos.\n\nDESCRIPCIÓN:\nLargo: 17 -"+
							" 18 cms.\nCabeza, cuello, dorso y pecho gris apizarrado. Garganta blanca. Bajo pecho y abdómen blancos. Tintes acanelados en el"+
							" abdómen y subcaudales. Rémiges gris oscuras bordeadas de gris apizarrado con cobertoras grises. Rectrices gris oscuras. Pico y"+
							" patas oscuras. En las hembras e inmaduros el gris es reemplazado en parte por tonos canela.",
                    Datos="La Diuca es una de las aves más abundantes y conocidas del territorio, ya que se encuentra en gran número dentro de su zona de"+
							" distribución y durante todo el año. Vive en todos los sectores. Campos y ciudades,  jardines y plazas, quebradas o montañas.\n"+
							"El nido, hecho de pastos y fibras, puede estar en cualquier arbusto, árbol chico o mata, pero nunca en el suelo. Los huevos,"+
							" generalmente 3 pero a veces 2 o 4, son de color azul-verdoso pálido cubiertos con muchas pintas y manchas café verdosas u"+
							" oliváceas, y de dimensiones de 24 mm. x 17 mm. app. \nLlevada como ave de jaula a Isla de Pascua en 1928, o posiblemente antes,"+
							" es el ave introducida más abundante en la actualidad en toda la isla, excepto los Motus. Se pueden observar una gran cantidad de"+
							" individuos parcialmente albinos, particularmente en la zona cuello-cabeza pero sólo en las zonas de Hanga-Roa, Mataveri, Orongo,"+
							" Puna-Pau y Tahai (Marin y Caceres, 2010)."
                },
                new AvesBD()
                {
                    id=25,
                    idHabitat = 0,
                    nomAve = "Fiofio",
                    urlSonido="sonidos/fiofio.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Fio-fio, chiflador, huiro, silbador\n\nDISTRIBUCION EN CHILE:\nVisitante y nidificante de primavera y verano"+
							"(Octubre a Marzo), entre Atacama y Tierra del Fuego.\nEn invierno migra hacia el norte de Sudamérica. \n\nHABITAT:\nBosques,"+
							" plantaciones, jardines, huertos.\n\nDESCRIPCION:\nLargo: 15 cms.\nEnvergadura: n/d\nPeso: 12 - 25 grms.\nCabeza cenicienta con"+
							" plumas en la corona algo alargadas y mancha central blanquesina. Por encima gris ceniza con tintes oliváceos. Garganta, cuello"+
							" y pecho más claro que el dorso. Abdómen blanquesino. Alas negruzcas con ligero tinte oliváceo; secundarias con bordes externos"+
							" blanquesinos, formando dos bandas transversales blancas. Cola negruzca. Pico y patas negruzcos.\n\nALIMENTACION:\nOmnivoro. Se"+
							" alimenta principalmente de insectos, aunque también come semillas, bayas y brotes tiernos de árboles frutales.\n\nREPRODUCCION:\n"+
							" Nidifica normalmente en Noviembre; a veces en Diciembre y hasta Enero (Goodall, 1946). Nido tipo taza, bastante comodo, hecho"+
							" de tallos de pasto, hojas, musgos o liquenes, forrados con plumas o papo de cardos, en arbustos tupidos o en bifurcaciones de"+
							" ramas de pinos jovenes, no muy altos. Postura de 2 - 3 huevos de 20 x 15 mms. app., blancos con pintitas rojizas.",
                    Datos="Ave de tamaño pequeño, es una de las especies más abundantes y mejor conocidas del territorio, encontrándose desde Atacama hasta"+
							" Tierra del Fuego y a alturas de hasta 2.000 m.s.n.m.. Sin embargo; su estadía es veraniega, ya que al llegar el otoño, migra"+
							" hacia el norte de Sudamérica a la zona amazónica de Perú y Brasil, llegando ocasionalmente hasta Colombia, para volver a aparecer"+
							" en los meses de Septiembre y Octubre nuevamente y no sólo en Chile, sino también en Argentina hasta la zona patagónica, Tierra"+
							" del Fuego e Isla de los Estados.\nDifícil de ver, ya que le gusta andar entre el follaje de los árboles y arbustos. Sin embargo,"+
							" su canto característico, un monosílabo algo triste semejante a \"fio-fio\" o \"fiofio-fiofio\" lo delata inmediatamente. "
                },
                new AvesBD()
                {
                    id=26,
                    idHabitat = 0,
                    nomAve = "Garza",
                    urlSonido="sonidos/garza.mp3",
                    Ficha="DISTRIBUCIÓN EN CHILE:\nentre Arica y La Serena.\n\nRegistros en la 8° y 11° regiones.\n\nHABITAT:\nZonas pantanosas y bordes de lagos,"+
							" lagunas y costeros.\n\nDESCRIPCIÓN:\nLargo: 56 cms.\nAdulto: Plumaje azul apizarrado; tinte violeta en cabeza y cuello. Pico"+
							" azulino con punta negra. Patas verde azuladas.\nSubadulto:\n Blanco manchado de azul.  Pico azulino con punta negra.\nInmaduro:"+
							" Blanco. Generalmente las primarias con punta negra.  Pico azulino con punta negra. ",
                    Datos="Este registro permanente de la garza azul en La Serena, provincia de Elqui, da cuenta de una posible colonización natural de estas"+
							" aves en nuestro país, instando también a revisar el estatus que se le asigna a la especie en la zona y muy especialmente el rango"+
							"de distribuciÓn de la Egretta caerulea en Chile.\nAño 2004. Rodrigo Barros Mc. envia una nota que dice: \"Con fecha 24 de Julio"+
							" de 2004, en una visita al Proyecto de la Ruta Interportuaria Talcahuano - Penco (8ªRegión), junto a Pablo San Martin, divisamos"+
							" un ejemplar solitario de Garza azul (Egretta caerulea) en los potreros que se ubican entre el cabezal norte del aeropuerto"+
							" Carriel Sur y el Rio Andalien. De acuerdo a la pagina Aves de Chile, esta especie tendria su limite sur de distribucion en La"+
							" Serena (4ª Region). Este avistamiento ampliaria considerablemente su distribucion hacia el sur. Pablo San Martín la habria vuelto"+
							" a avistar en el mismo sitio el dia 27 de Junio\" \nAño 2008. Varios registro en Lampa (Santiago) durante el  transcurso de ese"+
							" año. \nAño 2008. Otro registro (sin foto) de esta ave en la cabecera norte del fiordo Puyuhuapi, 11º Region, en la playa del"+
							" pueblo. Llevado a cabo por Jorge Mpodozis y Claudia Cecchi B. de la Facultad de Ciencias de la UCh: \"Esto fue entre el 3 y 8"+
							" de abril, todos los dias, consistentemente. Hasta donde sabemos no hay registros tan australes de esta magnifica ave.\"."
                },
                new AvesBD()
                {
                    id=27,
                    idHabitat = 0,
                    nomAve = "Gaviota Andina",
                    urlSonido="sonidos/gaviota_andina.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Gaviotín, caulle, quiulla\n\nDISTRIBUCIÓN EN CHILE:\nDe Arica hasta ñuble. Más escasa hasta Aysén.\n\nHABITAT:\nLagos"+
							" y lagunas de la alta cordillera. En invierno algunos ejemplares bajan hasta la zona costera.\nDESCRIPCIÓN:\nLargo: 44 - 45 cms.\n"+
							" Plumaje de verano: Cabeza negra; semicírculo blanco en el ojo. Cuello blanco. Dorso y cobertoras grisáceos. Pecho, abdÓmen,"+
							" subcaudales, supracaudales y cola blancos. Pecho con tinte rosado. Primarias negras con espejuelos blancos en las externas. Pico"+
							" y patas rojizo oscuro.\nPlumaje de invierno: Cabeza blanca con algunas manchas oscuras detrás del ojo. Patas más oscuras.\nInmaduros:\n"+
							" Cabeza gris pardusca. Dorso pardusco. Partes inferiores manchadas de pardo acanelando. Patas negras.",
                    Datos="Vive y anida durante verano en los lagos y lagunas de agua dulce en la alta cordillera de Los Andes desde el extremo norte hasta"+
							"ñuble y en menor número hasta la regiÓn de Aysén en el sur. Sin embargo, a la llegada del invierno baja hacia los sectores"+
							" pre-cordilleranos e incluso hasta la zona costera en busca de tiempos menos rigurosos, en donde se le puede ver en pequeñas"+
							"bandadas paseándose por el litoral.\nMuy característico durante el verano es la cabeza con un capuchÓn negro hasta el cuello"+
							" que la identifica fácilmente; sin embargo durante el invierno, la cabeza queda casi blanca, con unas ligeras manchas oscuras"+
							" detrás de los ojos.\nLa época de nidificaciÓn, cuya postura la realiza entre los meses de Diciembre y Enero, la realiza"+
							" exclusivamente en las lagunas de la alta cordillera, en donde generalmente construye un nido flotante con las plantas acuáticas"+
							" del sector, alejado de la ribera y anclado a otras plantas. También nidifica en el suelo en rocas o pequeños islotes en donde"+
							" los nidos son menos voluminosos. Coloca entre 2 y 3 huevos de color café verdoso claro con pintas y manchas púrpuras y en tonos"+
							" desde el café claro hasta casi negro.\nDurante el día, los adultos dejan los huevos al calor del sol mientras buscan peces en"+
							" las aguas para alimentarse, pero al aparecer los primeros vientos frios de la tarde, vuelven de inmediato al nido para proteger"+
							" a los huevos o las crías, haciéndolo con un grito penetrante y chillón."
                },
                new AvesBD()
                {
                    id=28,
                    idHabitat = 0,
                    nomAve = "Gaviota Dominicana",
                    urlSonido="sonidos/gaviota_dominicana.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Gaviota, caucau (araucano)\n\nDISTRIBUCIÓN EN CHILE:\nArica a Cabo de Hornos.\n\nHABITAT:\nzona costera e interior de"+
							" rios\n\nDESCRIPCIÓN:\nLargo: 60 - 62 cms.\nAdulto: cabeza, cuello, pecho, abdomen y cola blancos. Manto y lomo negro pizarra."+
							" Parte superior del ala negro pizarra con bordes blancos, parte inferior blanca con primarias negras. Pico amarillo con mancha"+
							" roja en la mandíbula inferior. Patas gris verdoso claro. Párpados rojos\nInmaduro: \nplumaje blanco sin manchas; dorso, cobertoras,"+
							" rémiges y cola negro pardusco. Pico amarillo pálido con punta oscura y mancha roja incipiente en la mandíbula inferior.\nJuvenil:"+
							" blancos manchados de café, especialmente en el dorso y cobertoras. Rémiges y cola cafe oscuro. Pico cafe oscuro.",
                    Datos="Es la gaviota más grande de sudamérica, con una notable zona de distribuciÓn. Vive y anida entre la isla Lobos de Tierra"+
							" norte de Perú) y la Peninsula antartica.\nSu alimento suelen ser peces, mariscos y crustáceos, aunque en las zonas cercanas"+
							" al hombre se ha convertido en omnívora buscando entre los desperdicios de alimentos que son arrojados al mar o que llegan a la"+
							" costa. También come los huevos y polluelos de otras especies e incluso de sus misma especie si los padres se descuidan, a los"+
							" cuales mata arrojándolos al suelo desde una cierta altura. Goodall dice en su libro que fuimos testigos de ataques a Caiquenes"+
							" pequeños en Tierra del Fuego, a los cuales los pescaban por el cuello y los elevaban unos 7 u 8 metros para después dejarlos"+
							" caer y repetían la acciÓn hasta matarlos. También en la costa de Perú viven principalmente de los huevos y polluelos de las aves"+
							" guaneras.\nSuelen anidar en diversos sitios, pero eligen preferentemente zonas planas en islas rocosas o acantilados costeros,"+
							" normalmente con 2 o 3 huevos de un tamaño aproximado de 71 x 51 mm, de color crema verdoso con manchas negras o café oscuras."+
							" En las aves inmaduras predominan tonos de pardo y blanco, llegando a su color de adulto alrededor del cuarto año."
                },
                new AvesBD()
                {
                    id=29,
                    idHabitat = 0,
                    nomAve = "Gaviota Franklin",
                    urlSonido="sonidos/gaviota_franklin.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Gaviotín, cagüil, caulle\n\nDISTRIBUCIÓN EN CHILE: \nMigratoria de verano.Abundante de Arica a Llanquihue;"+
							" menos abundante hasta Magallanes\n\nHABITAT:\nCostas, lagos, rios, campos agrícolas, basurales\n\nDESCRIPCIóN:\nLargo: 36 - 38 cms.\n"+
							" Epoca de reposo (verano austral): cabeza grisacea jaspeada de blanco con la corona negruzca hasta el ojo; anillo periocular"+
							" blanco. Manto y cobertoras grises. Cuello y partes inferiores blancas. Primarias externas grises con punta blanca y banda"+
							" subterminal negra; primarias internas y secundarias grises con punta blanca. Cola blanca. Pico negruzco. Patas cafe rojizas"+
							"oscuras.\nEpoca de reproducción (verano boreal): cabeza negra, circulo periocular blanco, pico rojo oscuro, tonalidad rosada"+
							" en las partes inferiores.\nInmaduros: partes superiores con tonos parduscos; cola con banda negra.",
                    Datos="Anida al interior del Oeste Norteamericano. Durante el invierno boreal, migra hacia el sur llegando hasta Magallanes. Dentro de"+
							" Chile, con abundancia hasta Valdivia, y en menor número más al sur. Tanto a la llegada alrededor de Septiembre como a la ida en"+
							" Mayo se pueden ver enormes bandadas, a veces de miles de ejemplares.\nSe alimenta de insectos que caza en el aire o en el suelo,"+
							" animales marinos de superficie y lombrices. Es posible que aves no aparejadas se queden en Chile durante el invierno."
                },
                new AvesBD()
                {
                    id=30,
                    idHabitat = 0,
                    nomAve = "Gaviota Garuma",
                    urlSonido="sonidos/gaviota_garuma.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Garuma, gaviotin gris, San Andres\n\nDISTRIBUCIÓN EN CHILE:\nArica a Corral. Ocasionalmente mas al sur hasta el"+
							" Golfo de Penas.\n\nHABITAT:\nPlayas y desierto nortino.\n\nDESCRIPCIÓN:\nLargo: 42 - 44 cms.\nSin dimorfismo sexual. Cabeza blanca"+
							" en verano; y gris pardusca en invierno. Cuerpo gris, mas oscuro en las partes superiores. Primarias negras; secundarias grises"+
							" con punta blanca formando una linea terminal. Cola gris con banda subterminal negruzca. Patas negras. Pico negro.\nALIMENTACION:\n"+
							" Principalmente Emerita analoga, conocido como \"limanche\" o \"pulgon de mar\". Tambien peces y poliquetos.\n\nREPRODUCCION\n:Anida en"+
							" pleno desierto de la zona norte, entre Tarapaca y Atacama, y hasta unos 100 kms. hacia el interior en zonas sin vegetacion ni"+
							" agua. La postura ocurre entre los meses de Noviembre y Enero. Los nidos son suaves excavaciones redondeadas en el arido suelo,"+
							" generalmente al lado de una piedra, en donde colocan 1 o 2 huevos de color de fondo variable entre blanco levemente grisaceo a"+
							" salmon palido, con algunas pintas en diferentes tonos de castaño; tamaño de 58 x 41 mm. app.. La incubacion dura entre 29 y 32"+
							" dias. Ambos adultos participan tanto en la incubacion como en la alimentacion de las crias, turnandose usualmente de noche. La"+
							" actividad reproductiva es marcadamente estacional (Cikutovic et al., 1988) y no hay reproduccion en los años en que se desarrolla"+
							"el fenomeno del Niño (ENSO) (Guerra et al., 1988).",
                    Datos="Ave tipica de Sudamerica, se distribuye por la costa desde el centro de Ecuador hasta la zona sur de Chile. Hay registros en las"+
							" Islas Falkland (Malvinas), Colombia y Panama.\nDe color gris laucha y alas negras, se distingue con facilidad de las otras"+
							" gaviotas. Vive normalmente en las playas arenosas, ya que su alimento preferido es el pequeño crustaceo conocido como \"pulgon"+
							" de mar\". En cualquier epoca del año se pueden observar corriendo por la arena de las playas, siguiendo a la ola que se aleja en"+
							" busca de los pulgones delatados por las burbujitas de aire que aparecen en la arena. Aprovechan las dunas interiores o los"+
							" roquerios de islotes para descansar.\nUna caracteristica de esta especie es el color blanco en la punta de las secundarias,"+
							" formando una linea nitida que se ve con mayor claridad durante el vuelo."
                },
                new AvesBD()
                {
                    id=31,
                    idHabitat = 0,
                    nomAve = "Golondrina",
                    urlSonido="sonidos/golondrina.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Golondrina, golondrina de rabadilla blanca, pilmaiquen\n\nDISTRIBUCIÓN EN CHILE:\nAtacama a Tierra del Fuego"+
							"\n\nHABITAT:\nEn el campo y ciudades.\n\nDESCRIPCIÓN:\nLargo: 13 - 14 cms.\nPartes superiores de la cabeza, cuello trasero, dorso"+
							" y lomo de color negro con brillos metálicos azulinos. Garganta, cuello delantero, pecho, abdómen y rabadilla blancos. Alas y"+
							" cola negras con algo de brillo metálico verdoso. Pico negro pequeño. Patas negras.",
                    Datos="Especie abundante en su zona de distribución que abarca desde el extremo sur hasta Atacama, y desde la zona costera hasta la"+
							" precordillera. En la zona de Magallanes es ave migratoria de verano.\nUna característica de esta ave es que se encuentra muy a"+
							" gusto viviendo en las ciudades o en zonas pobladas, y anidando en aleros y techumbres de casas o agujeros de muros. Normalmente"+
							" tiene dos posturas durante el año, en los meses de Septiembre y Diciembre; y en ocasiones hasta una tercera en Febrero. El nido,"+
							" forrado con plumas, es generalmente de dificil acceso por lo estrecho de la entrada. La nidada tiene de 3 a 5 huevos de color"+
							" blanco, de tamaño 19 x 14 mm. app."
                },
                new AvesBD()
                {
                    id=32,
                    idHabitat = 0,
                    nomAve = "Huala",
                    urlSonido="sonidos/huala.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Huala, Guala\n\nDISTRIBUCIóN EN CHILE:\nCoquimbo a Biobio\n\nHABITAT:\nLagos, lagunas, embalses, tranques, aguas"+
							" mansas en general; también en zonas costeras.\n\nDESCRIPCIóN:\nLargo: 78 cms.\nCabeza grisácea con moño gris oscuro. Cuello"+
							" café acanelado en la parte anterior y lados y gris en la parte posterior. Final anterior del cuello, pecho y abdómen blancos."+
							" Dorso y cobertoras alares gris oscuro variegado con manchitas canelas. Manchas blancas en el ala cuando aletea. Pico puntiagudo"+
							" negruzco. Patas negruzcas. Ojos rojos. ",
                    Datos="El Huala se encuentra entre Atacama y Tierra del Fuego, sin embargo es más abundante en la zona sur. No sube hacia la cordillera;"+
							" pero sí entra al mar especialmente en las zonas cercanas a la desembocadura de rios. Aunque en algún momento pudiera ser"+
							" confundido con pato, su largo cuello y su pico largo y puntiagudo lo caracterizan. Evita volar, salvo para huir de algún peligro"+
							" o emigrar a otros lugares; pero en el agua es excelente nadando o zambulléndose. Las patas colocadas muy atrás son excelentes"+
							" propulsores para nadar o bucear; sin embargo, por esta característica es muy torpe al momento de caminar, lo cual hace en muy"+
							" pocas ocasiones, como por ejemplo, para subirse a sus nidos flotantes.\nSe alimenta de peces pequeños, alevines, plantas e"+
							" insectos acuáticos que obtiene al zambullirse, pudiendo permanecer largo rato bajo el agua.\nConstruye nidos flotantes con"+
							" totoras y plantas que arranca del fondo. La nidada suele ser de 4 a 6 huevos elípticos de color blanco azulado, de dimensiones"+
							" de 56 mm. x 39 mm. app. Por lo general el nido posee material sobrante que ocupa a la menor señal de alarma para tapar los"+
							" huevo y deslizarse hacia el agua."
                },
                new AvesBD()
                {
                    id=33,
                    idHabitat = 0,
                    nomAve = "HuedHued",
                    urlSonido="sonidos/huedhued_sur.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Gallereta, tuta, huez-huez\n\nDISTRIBUCIÓN EN CHILE:\n desde el rio Biobio hasta Magallanes\n\nHABITAT:\nEspesuras de"+
							" las grandes selvas y bosques.\n\nDESCRIPCIóN:\nLargo: 25 cms.\nCabeza apizarrada oscura con  frente y corona rojo ladrillo. Cuello"+
							" y dorso apizarrado oscuro. Lomo con leve tinte rufo, acentuándose más hacia las supracaudales. Pecho rufo castaño; hacia el"+
							" abdomen rufo suave con rayitas transversales negras finas; flancos y calzones rufo pardusco. Alas con primarias negras y"+
							" cubiertas apizarradas bordeadas de rufo oscuro. Cola negra. Pico negruzco. Patas negras y grandes.",
                    Datos="Ave de característica muy tímida, vive en medio de la espesura de las zonas boscosas, siendo muy difícil verla, incluso después"+
							" de haber identificado su canto. Tanto es así que para verla, después de haberlo escuchado, hay que quedarse inmóvil por mucho"+
							" rato para que pueda vérsele aparecer, y huyendo ante el menor asomo de un posible peligro\nEl tono rufo castaño del pecho puede"+
							" variar de un ave a otra, siendo en algunos casos más claro y en otros más oscuro. Sin embargo, esta diferencia de tonalidad,"+
							" debido al tipo de habitat que frecuenta, la típica semi-oscuridad del bosque denso, es muy difícil de notarla.\nPosee tres"+
							" tipos de cantos: uno en que va bajando de tono, nota a nota; otro que es un grito muy fuerte y penetrante; y un tercero, de"+
							" tono bajo, que parece decir &quot;Hued-hued-hued&quot; y del cual deriva su nombre tanto es español (Hued-Hued) como en inglés"+
							" y alemán (Huet-huet) o en mapuche (Wëd-wëd). Otra característica de esta ave, es la que poseen todos los miembros de la familia"+
							" Rhinocryptidae y que es llevar la cola parada.\nSe diferencia del Hued-hued castaño (P. castaneus) tanto por su zona de"+
							" distribución, topándose en el rio Biobio; como por tener básicamente la garganta y cuello delantero de tono apizarrado, a"+
							" diferencia de la otra subespecie que los tiene de tono rufo castaño.\nPara anidar, sigue también las costumbres de la familia,"+
							" cavando una cueva profunda y grande en un corte de terreno muy vegetado cercano a una aguada o riachuelo; o bien debajo de"+
							" algun tronco o raiz en medio de la selva. También anida en el tronco hueco de algún árbol a una cierta altura del suelo,"+
							" contrastando en este sentido con los otros miembros de la familia (turcas y tapaculos) que no lo hacen. En los nidos, hechos"+
							" exclusivamente de pastos secos, depositan normalmente 2 huevos, y excepcionalmente 3, de color blanco y de dimensiones promedio"+
							" de 38 x 28 mm."
                },
                new AvesBD()
                {
                    id=34,
                    idHabitat = 0,
                    nomAve = "Jilguero",
                    urlSonido="sonidos/jilguero.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Jilguero, canario\n\nDISTRIBUCIÓN EN CHILE:\nDesde el valle de Copiapó hasta Tierra del Fuego.\n\nHABITAT:\nzonas"+
							" de matorrales y arboladas.\n\nDESCRIPCIÓN:\nLargo: 13 - 14 cms.\nMacho: Cabeza amarilla verdosa más oscura hacia la nuca y corona"+
							" negra. Cuello amarillo verdoso con la parte delantera y garganta negra. Dorso amarillo verdoso oscuro rayado longitudinalmente"+
							" de negruzco. Pecho amarillo verdoso y abdomen más blanquecino. Alas con rémiges negras y mancha amarilla en la base de las"+
							" primarias y secundarias; cobertoras oscuras con punta amarilla formando dos lineas de ese color.\nHembra: similar al macho,"+
							" careciendo de la corona y garganta negras. Partes inferiores menos amarillentas y más verdosas.\n\nSe le encuentra desde Atacama "+
							" hasta Tierra del Fuego, y desde la zona costera hasta los 1.500 m.s.n.m., siendo más abundante en los bosques de la zona sur y"+
							" migrando en invierno hacia la zona central.",
                    Datos="Se le identifica por su canto melódico y su plumaje de tonos amarillo verdosos. Muy parecido al Chirihue (Sicalis luteola"+
							" luteiventris), se diferencia por tener la cabeza de color amarillo verdoso con la nuca negra, y el Chirihue por tenerla café"+
							" desde las mejillas hacia arriba. Además, la corona, frente y garganta son negras, colores que el Chirihue no posee.\nFrecuenta"+
							" en primavera los campos cultivados, huertos y jardines cercanos de las casas de poblados y fundos, dispersándose en invierno"+
							" por los valles y llanuras,  y alimentándose principalmente de semillas.\nAnida en Septiembre o meses antes si el invierno es"+
							" suave, armando un nido en bifurcaciones de ramas en árboles frutales. Este nido es del tipo taza abierta, hecho con pastos,"+
							" musgos y fibras y forrado interiormente con plumas y lanas. En su interior coloca de 3 a 6 huevos blancos con ligero tono"+
							" celeste liso, y a veces con insinuaciones de pintas finas de tono café. Tamaño promedio de 18 x 13 mms."
                },
                new AvesBD()
                {
                    id=35,
                    idHabitat = 0,
                    nomAve = "Loica",
                    urlSonido="sonidos/loica.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Loica, lloica, milico\n\n DISTRIBUCION EN CHILE:\nAtacama a Magallanes\nHABITAT: preferentemente en el suelo en"+
                            " terrenos bajos y húmedos. Hacia la cordillera hasta alturas de 2.500 mts.\n\nDESCRIPCION:\nLargo: 26 - 28 cms.\n Macho: Cabeza"+
                            " y cuello pardo oscuro. Notoria superciliar blanca con rojo hacia la frente. Dorso y cola pardo oscuro variegado con cafe. Cuello"+
                            " delantero, pecho y parte superior del abdómen rojo vivo. Zona inferior del abdómen parda oscura. Alas café variegada con pardo"+
                            " oscuro. Doblez del ala rojo. Pico pardo oscuro puntiagudo. Patas pardas.\nHembra: como el macho, pero con superciliar, garganta"+
                            " y cuello blanquesino; pecho y abdómen rojo pálido, algunas plumas bordeadas de blanco sucio.\n\nALIMENTACION:\nInsectos, frutos, semillas"+
                            "\n\nREPRODUCCION:\nEntre Septiembre y Noviembre. El nido es grande, suelto y formado por pasto seco bien unido y colocado en el suelo muy"+
                            " bien escondido entre pasto alto. Muy cuidado por la hembra, ésta nunca llega directamente al nido, sino que baja cerca de él y camina"+
                            " agachada hasta éste. Al salir, lo hace de igual forma, como una manera de que nadie se entere en donde está.\nLa nidada generalmente es"+
                            " de 3 huevos, y a veces 4, de dimensiones 30 x 20 mm.; de un fondo café-rosado muy claro,  muy salpicado de machas café-rojizo, negras y ocre.",
                    Datos="En Argentina, Chile e Islas Malvinas, Georgias del Sur y Sandwich del Sur. En Chile la raza tipica.\nFácil de identificar por su gran mancha roja"+
                            " en la parte delantera, la loica se encuentra en gran parte del territorio. Gusta de terrenos bajos y húmedos buscando su alimento tanto en el"+
                            " suelo como en los arbustos. Canto poco variado pero agradable. Solitaria o en pareja, tiende a juntarse en bandadas durante el invierno."
                },
                new AvesBD()
                {
                    id=36,
                    idHabitat = 0,
                    nomAve = "Martin Pescador",
                    urlSonido="sonidos/martin_pescador.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): Martín pescador \n\n DISTRIBUCIÓN EN CHILE:\ndesde Concepción a Tierra del Fuego. Rara vez hasta Colchagua \n"+
                          "\nHABITAT:\nLagos, lagunas, tranques, esteros, rios, bahías marinas, y en general aguas tranquilas y claras rodeadas de árboles."+
                          "\n\nDESCRIPCIÓN:\n Largo: 43 - 45 cms.\n"+
                          "Macho :\n Cabeza grande azul grisácea, plumas de la corona con centro negro y algo levantadas. Plumas del dorso azul grisáceas con finas rayas negras y moteadas de blanco. Garganta y lados del cuello blanco. Pecho, adómen, subcaudales, subalares y axilares rufo intenso. Cola negruzca con bandas transversales blancas. Pico negro puntiagudo."+
                          "\nHembra:\n se diferencia del macho porque tiene el pecho azul grisáceo sin teñido de rufo; y abdómen rufo, separados por una linea blanca.",
                    Datos="Ave de la zona sur de Chile, generalmente se le encuentra en ramas de árboles al borde de rios y lagos, pero sin que menosprecie el agua salada de zonas marinas como estuarios, canales y bahías de las numerosas islas de ese sector."+
                          "Muy fácil de identificar, por su tamaño y colores, el Martín pescador  permanece inmóvil sobre una rama o tronco al borde del agua esperando a que algún pez se le acerque para lanzarse de cabeza sobre él y capturarlo con su gran pico, para luego emerger y volver a posarse en la rama."+
                          "Anida entre los meses de Noviembre y Diciembre. Construye un túnel de un par de metros de profundidad terminado en una gran cueva enfrente de un rio o lago; o ensenada marina. Coloca de 3 a 5 huevos blancos, brillantes y de cáscara muy frágil. Tamaño de 50 mm. x 32 mm. app."
                },
                new AvesBD()
                {
                    id=37,
                    idHabitat = 0,
                    nomAve = "Minero Cordillerano",
                    urlSonido="sonidos/minero_cordillerano.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):Minero, caminante, pachurra.\n\n"+
                          "DISTRIBUCIÓN EN CHILE:\n"+
                            "sur de Antofagasta a Malleco.\n\n"+
                            "HABITAT:\n"+
                            "zona cordillerana; en pendientes arbustivas y bordes de bosques, entre los 2.000 y 3.000 msnm."+
                            "En invierno hay desplazamientos hasta la zona costera. \n\n"+
                            "DESCRIPCIÓN:\n"+
                            "Largo: 16 cms."+
                            "Cabeza y partes superiores pardo grisáceo. Supracaudales con cierto tono acanelado. Garganta y pecho superior blanco sucio. Pecho inferior y abdomen acanelado cremoso. Alas con la barba interna de las rémiges primarias y secundarias de tono rufo acanelado. Cola con rectrices centrales gris acanelado en la base; laterales con base gris rojiza; banda ancha negra subterminal; punta gris acanelado. Pico negro. Patas negras.",
                    Datos="Comparte una parte de su zona de distribución por la ancha banda rojiza en sus alas, notoria especialmente durante en vuelo."
                },
                new AvesBD()
                {
                    id=38,
                    idHabitat = 1,
                    nomAve = "Paloma de alas Blancas",
                    urlSonido="sonidos/paloma_alasblancas.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nPaloma, paloma cantora, tortola de Arica, cuculi.\n\n"+
                    "DISTRIBUCIÓN EN CHILE:\nTarapacá a Coquimbo.Mas al sur hay algunos registros en Los Andes, Petorca, Quintero, Ritoque y Concon."+
                    "\n\nHABITAT:\nValles, oasis, plantaciones, zonas arboladas, plazas"+
                    "\n\nDESCRIPCIÓN:\nLargo: 31 - 32 cms."+
                    "\nTodo el cuerpo de tonos grisáceos, más claro en el cuello, pecho y abdómen. Plumas exteriores de las cobertoras alares blancas, formando una banda ancha de ese color visible incluso con el ala recogida. Mancha negra bajo las mejillas. Alas negruzcas. Pico grisáceo. Patas rojas. Zona periocular desnuda de color azulino.",
                    Datos="Se le encuentra normalmente en la zona costera y valles bajos de Ecuador y Perú; y en Chile, principalmente en los valles bajos de Arica (Lluta y Azapa) y en otros pocos oasis en la zona norte y a alturas no superiores de 1.500 mts ( 5.000 ft.)."+
                    "Sin embargo, esta especie ha experimentado en los últimos 10 años una rápida colonización hacia el sur. Araya (1986) la restringían a los valles, oasis  y tamarugales del salar de Pintados y Quillagua (Tarapacá). Posteriormente , Araya (1998) extendieron su distribución hasta Copiapó (Atacama). Seeger y Aguirre (1996) comprobaron su presencia en el estero Lagunillas, en Coquimbo, lugar cercano a la observación de una pareja de Palomas de alas blancas que anidaba en la localidad costera de La Herradura, ocurrida el 21 de Enero de 1998."
                },
                new AvesBD()
                {
                    id=39,
                    idHabitat = 0,
                    nomAve = "Parina Grande",
                    urlSonido="sonidos/parina_grande.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nParina, parinagua"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nZona de la puna desde el límite norte hasta Chañaral."+  
                    "\n\nHABITAT:\nLagunas salobres altiplánicas"+
                    "\n\nDESCRIPCIÓN:\nLargo: 110 - 120 cms."+
                    "\nTodo el plumaje de color blanco con tinte rosado muy suave; rosado más intenso en la parte delantera del cuello y superior del pecho. Cubiertas alares con manchas rojas. Primarias y secundarias negras, también notorias con el ala recogida. Pico amarillo en la mitad basal y resto negro. Patas amarillo suave.",
                    Datos="La más grande de esta familia, , al igual que las otras dos especies de la familia"+ 
                    "presentes en Chile, se puede distinguir por el color de sus tarsos y patas. Los posee de color amarillo suave, en lugar de rojo ladrillo "+
                    "; o córneo azulado con rodillas y patas rojas, como el Flamenco chileno ."+
                    "Como todos los miembros de esta familia, anidan en colonias, en lugares solitarios, en las partes bajas de lagos y lagunas o cerca de éstas, construyendo un nido con barro similar a un cono sin punta y con forma de taza, en el cual depositan un huevo blanco. Los pollos son nidífugos aprendiendo a nadar rápidamente."
                },
                new AvesBD()
                {
                    id=40,
                    idHabitat = 0,
                    nomAve = "Pato Jergon",
                    urlSonido="sonidos/pato_jerjon.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nPato jergón grande, pato jergón"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\ndesde Arica a Tierra del Fuego"+ 
                    "\n\nHABITAT: \nAguas y riberas de lagos, lagunas, tranques, pantanos, esteros, etc."+ 
                    "\n\nDESCRIPCIÓN:\nLargo: 51 cms."+
                    "\nCabeza parda con rayas pequeñas negras. Cuello pardo con pintas negras. Garganta más clara. Manto y lomo con plumas pardas oscuras marginadas de café claro. Pecho y abdómen café claro con pintas negras pequeñas. Vientre blanquesino. Alas pardas con espéculo negro marginado con café claro. Cola puntiaguda. Pico amarillo con culmen y punta negra. Patas grisáceas.",
                    Datos="Este es uno de los patos más comunes en Chile, encontrándose a lo largo de todo el territorio. En la zona norte, aunque menos abundante, puede  subir a la cordillera hasta alturas de 4.000 metros; sin embargo en la zona central, más abundante, suele ser ave de terrenos bajos. En Tierra del Fuego es visitante de verano. Se alimenta de hiervas y semillas, las cuales las come tanto dentro como fuera del agua."+
                    "El nido es una depresión en el suelo, cercano a la ribera, forrado con plumas pequeñas y con pasto cercano para tapar los huevos durante la ausencia de la hembra. La nidada consta de entre 4 y 10 huevos de 54 mm. x 37 mm. aproximadamente."
                },
                new AvesBD()
                {
                    id=41,
                    idHabitat = 0,
                    nomAve = "Pato Juarjual",
                    urlSonido="sonidos/pato_juarjual.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nPato juarjual, pato crestón"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nTalca a Cabo de Hornos; con desplazamientos más al norte hasta la cordillera de Santiago."+   
                    "\n\nHABITAT:\nLagos, lagunas, embalses, bofedales y aguas mansas de la zona cordillerana. Desde Aysén al sur, también en la zona costera."+
                    "\n\nDESCRIPCIÓN:\nLargo: 50  cms."+  
                    "\nCabeza gris parda, cuello blanco. Lomo pardo oscuro. Pecho y abdómen rojizo pálido. Alas gris pardas. Espéculo rojo cobrizo con brillo verde con banda trasera negra. Banda blanca en la punta de las secundarias. Cola parda a negra con brillo púrpura. Pico negruzco. Patas grises oscuras. Ojo rojo.",
                    Datos="Esta especie de pato se encuentra en las lagunas y bofedales de la cordillera en su zona norte de distribución, en donde vive y anida. Sin embargo, desde Aysén hacia el sur vive tanto en las lagunas interiores de tierras altas como en la zona costera, buscando incluso su alimento en las pozas de agua salada formadas por la baja marea o comiendo desperdicios arrojados por el hombre. Una característica de esta especie son las plumas de la nuca similar a un pequeño moño."+
                    "Si bien su zona de distribucion se encuentra de Talca al sur, hacia el norte hay registros hasta la zona cordillerana de Santiago, superponiéndose a la de la subespecie"+
                    "alticola en donde se pueden ver grupos mixtos. Ambas razas se pueden diferenciar entre sí por el tamaño, siendo la raza típica algo más pequeña; y por el ojo de color rojo en la raza típica y anaranjado en la alticola."+
                    "Anida en los pastos a orilla de los lagos o lagunas, colocando de 5 a 8 huevos de 63 mm. x 42 mm. aproximadamente."
                },
                new AvesBD()
                {
                    id=42,
                    idHabitat = 0,
                    nomAve = "Pato Real",
                    urlSonido="sonidos/pato_real.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nPato real"+  
                    "\n\nDISTRIBUCIÓN EN CHILE:\ndesde Vallenar a Tierra del Fuego"+     
                    "\n\nHABITAT:\nLagos, lagunas, tranques, vegas, rios."+
                    "\n\nDESCRIPCIÓN:\nLargo: 51 cms."+
                    "\nCabeza y cuello negros. Frente y mejillas blancos. Parte poserior de la cabeza con brillos metálicos verdosos. Dorso y escapulares negros con plumas marginadas de blanco. Pecho superior con barras transversales blancas y negras. Pecho inferior y abdómen blanco. Flancos y subcaudales rufos. Las alas con primarias negras, subalares grises y mancha blanca que se ve cuando vuela. Cola negra. Pico negro. Patas negras.",
                    Datos="De colores generales negro por encima y blanco por debajo, se le suele reconocer por la mancha blanca en la cara, y por las franjas blancas en las alas mientras vuela. Distribuido entre el rio Huasco (Vallenar) por el norte y Tierra del Fuego por el sur, es más abundante desde Valdivia al sur; y en extremo sur, es decir Tierra del Fuego, es un visitante de mediado de primavera y verano."+
                    "Mal zambullidor, es buen volador y suele cambiar de lagunas con facilidad en busca de un mejor lugar. Esquivo, es muy dificil acercárcele, ya que nadan hacia el centro de la laguna o vuelan hacia la otra orilla aunque la persona aún se encuentre lejos de ellos. Herbívoro, se alimenta de vegetales que encuentra a orilla de las aguas o en praderas abiertas."+
                    "Para anidar, elige sitios secos un poco alejados de la orilla, escondiendo el nido entre champas de pasto o cardos y forrados con plumillas. Coloca de 6 a 10 huevos de tono cremoso. Dimensiones de 61 mm. x 41 mm. app."
                },
                new AvesBD()
                {
                    id=43,
                    idHabitat = 0,
                    nomAve = "Pequen",
                    urlSonido="sonidos/pequen.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nPequén"+ 
                    "\n\nDISTRIBUCIÓN EN CHILE:\nPica (I region) a Valdivia."+ 
                    "\n\nHABITAT:\nbusca terrenos arenosos de la zona costera y faldeos poco vegetados de la precordillera."+
                    "\n\nDESCRIPCIÓN:\nLargo: 26 cms."+
                    "\nCabeza y partes superiores de color café terroso con manchas blanquesinas, más gruesas en el cuerpo. Lineas superciliares blanquesinas desde la zona basal del pico superior hasta las auriculares. Garganta y cuello blanquesinos separados por un collar oscuro. Pecho y flancos blanco cremoso con barras más oscuras. Abdómen, subcaudales y calzones blanco cremoso. Cola café amarillenta al centro y blanquesina a los extremos, con barras gruesas transversales oscuras. Ojos amarillos y plumas perioculares pardo oscuras.  Pico corto y ganchudo.",
                    Datos="Dentro de su habitat es relativamente fácil verla, ya que suele permanecer posada en algún montículo de tierra, poste o baranda, observando todo a su alrededor, pudiendo girar su cabeza en 360º. "
                },
                new AvesBD()
                {
                    id=44,
                    idHabitat = 0,
                    nomAve = "Perdicita Cojon",
                    urlSonido="sonidos/perdicita_cojon.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nCojón, corral, cojón corralero, huancho, kotel"+   
                    "\n\nDISTRIBUCIÓN EN CHILE:\ndesde Antofagasta a Tierra del Fuego"+ 
                    "\n\nHABITAT:\nzonas de matorrales y planicies de la alta cordillera. Hacia el extremo austral llega a la zona costera."+
                    "\n\nDESCRIPCIÓN:\nLargo: 21 - 23 cms."+
                    "\nMacho: \nCabeza, cuello trasero, dorso, supracaudales y cola parduscos con plumas ribeteadas de ocre, dándole una apariencia aperdizada. Frente gris azulada. Garganta blanca rodeada por una banda negra terminada en punta en el centro del cuello. Lados de la cara, lados del cuello y pecho gris azulado. Abdómen blanquesino separado del pecho por una linea negra. Flancos aperdizados. Alas negruzcas con bordes claros. Pico pardo. Patas amarillentas."+
                    "\nHembra: \nsin los tonos grisáceos de la frente, cuello y pecho del macho, siendo reemplazados por tonos aperdizados semejantes al dorso.",
                    Datos=" La Perdicita cojón es habitante de la alta cordillera. En la zona norte de su area de distribución se le encuentra por sobre los 3.500 m.s.n.m., y hasta los bordes en donde comienza la nieve; mientras que en la zona central por lo general vive desde los 2.500 m.s.n.m. y a alturas menores más al sur. Muchas veces en estas zonas baja hacia el Valle Central y quebradas de la pre-cordillera durantes las grandes nevazones de invierno, en  busca de refugio y alimento."+
                    "Hacia el extremo austral, Magallanes y Tierra del Fuego, se le ve tanto en lo que resta del cordón andino, como en pampas e incluso en la zona costera."+
                    "Confundible a primera vista con la "+
                    ", es un poco mayor que ésta. El macho se diferencia también por no tener unido a través de una linea negra, el collar negro del cuello con la banda negra que separa el pecho del abdómen. Y la hembra por ser más grande y de colores más vivos que la hembra de la "+
                    ". Su alimentación también es a base de semillas y pasto verde."
                },
                new AvesBD()
                {
                    id=45,
                    idHabitat = 0,
                    nomAve = "Perdicita Cordillerana",
                    urlSonido="sonidos/perdicita_cordillerana.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nPerdiz cordillerana, tortolón, perdizón"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nentre Antofagasta y Magallanes "+
                    "\n\nHABITAT:\nzonas aguadas y húmedas de la alta cordillera "+
                    "\n\nDESCRIPCIÓN:\nLargo: 29 - 30 cms."+
                    "\nCabeza, cuello, partes superiores, cobertoras y pecho con tono aperdizado. Supracaulades rufo pálido con manchas negras. Garganta leonado pálido. Abdomen y subcaudales canela pálido a oscuro. Axilares y subalares canela pálido. Rémiges pardo oscuro. Rectrices rufo pálido con vermiculaciones negruzcas. ",
                    Datos="Ave exclusiva de la zona de la Puna entre Antofagasta por el norte y Ultima Esperanza (Región de Magallanes) por el sur, aunque siendo en este último lugar una especie bastante rara "+
                    "Se le encuentra de preferencia en vegas y terrenos pantanosos al fondo de valles y quebradas en cuyas laderas la nieve se está derritiendo. Su alimento que consiste básicamente de semillas. Sólo en los inviernos muy rigurosos baja algunos cientos de metros en busca de mejores condiciones climáticas, pero nunca llega a la zona precordillerana."+
                    "En general se puede mostrar bastante mansa a la presencia humana; sin embargo, el excelente mimetismo con el entorno hace que detectar su presencia sea difícil. Al levantar vuelo, este es rápido y zigzageante. "
                },
                new AvesBD()
                {
                    id=46,
                    idHabitat = 0,
                    nomAve = "Perrito",
                    urlSonido="sonidos/perrito.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): \nPerrito, perroHuasco a Llanquihue."+
                    "\n\nHABITAT:\nOrillas de lagos, lagunas, desembocaduras de rios y terrenos pantanosos. "+
                    "\n\nDESCRIPCIÓN:\nLargo: 42 cms."+     
                    "\nCorona, frente, garganta, pecho, abdómen, flancos y cola blancos. Nuca negra con linea gruesa del mismo color que llega hasta bajo el ojo. Parte posterior del cuello, manto, lomo y alas negras. Pico recto y largo negro. Patas largas rojas a rosadas. Ojos rojos. "+
                    "\n\nALIMENTACION:\nInsectos acuaticos y otros invertebrados que captura en la superficie del agua o sondeando en el barro de las riberas con su especializado pico fino, largo y recto."+
                    "Arma su nido sobre champas de vegetación que apenas asoman sobre el agua, forrándolo con las mismas tiras secas y formando un plato. La nidada es de 3 o 4 huevos de fondo café con leche y con muchas manchas gruesas pardas a pardas oscuras. Dimensiones de 46 mm. x 32 mm. app.",
                    Datos="Inconfundible. Por sus colores y forma es una de las aves más vistosas y elegantes. Dentro de su zona de distribución, puede ser observado durante todo el año, en bordes de aguas o zonas pantanosas."+
                    "Se le encuentra principalmente en la zona central hasta Concepción, en grupos a veces numerosos. Escaso más al sur de esta ciudad, llegando hasta Llanquihue. Hacia el norte, hasta Huasco (3º Región) (Araya y Millie, 1998); con algunos registros mas norteños: el 1º de Noviembre de 1996 fueron observados dos Perritos en el sector de Rinconada en la bahía de Mejillones (2ºRegión) y otros dos en la desembocadura del rio Lluta, Arica, en Septiembre de 1997. "+    
                    "No sube hacia la cordillera,  pero en la zona cordillerana del  norte es reemplazado por su pariente próximo."
                },
                new AvesBD()
                {
                    id=47,
                    idHabitat = 0,
                    nomAve = "Picaflor",
                    urlSonido="sonidos/picaflor.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nPicaflor chico, pingarita"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nAtacama a Tierra del Fuego;y en la isla Robinson Crusoe del archipiélago de Juan Fernández. "+
                    "\n\nHABITAT:\nBosques, quebradas aguadas, jardines; y en general, lugares floridos"+
                    "\n\nDESCRIPCIÓN:\nLargo: 11 cms."+
                    "\nMacho   : \nCabeza verde con corona roja anaranjada brillante. Garganta verde con manchitas bronceadas brillantes.  Por encima verde con brillo bronceado. Por debajo verde grisáceo. Flancos y cola verdes bronceados. Pico recto negro."+
                    "\nHembra   : \nAlgo más pequeña que el macho; y con la corona sin el brillo rojo, siendo del mismo tono que el dorso.",
                    Datos=" Después del Picaflor de Arica (Eulidia yarrellii) que mide 8 cms. de largo, el Picaflor "+
                    "es la segunda ave más chica de Chile. Su distribución es bastante amplia, ya que se encuentra desde el valle de Huasco (región de Atacama) por el norte hasta Magallanes y Tierra del Fuego por el sur; y desde la zona de la costa hasta unos 2.000 m.s.n.m.. En la mayor parte de su zona de distribución es ave residente; sin embargo, en el extremo sur desaparece en el invierno, apareciendo en Atacama en donde sólo se conoce como visitante de invierno, lo que obviamente implica una migración estacional. "+
                    "Su alimento consiste en el polen y néctar de las flores, los que obtiene manteniéndose fijo en el aire con un aleteo rapidísimo y metiendo su largo y delgado pico en el interior de éstas. Aunque en toda época del año es posible ver picaflores en los parque o jardines, durante el verano, aprovechando la mayor cantidad de flores, suele subir hacia las quebradas aguadas de la precordillera; en cambio, a la llegada del invierno baja hacia el Valle Central y sus alrededores en busca de climas menos fríos. "+
                    "Durante el verano, anida en ramas de árboles que suelen estar sobre aguas de riachuelos, en donde construye un nido colgante "+
                    "sobre éstas, empleando pastos, musgos y otros vegetales blandos, muy bien trabajados y moldeados. Coloca 2 huevos blancos algo opacos, alargados, de tamaño de 15 x 9 mm. app.,  postura que realiza entre los meses de Octubre y Noviembre."
                },
                new AvesBD()
                {
                    id=48,
                    idHabitat = 0,
                    nomAve = "Piden",
                    urlSonido="sonidos/piden.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nPidén, cotuta "+
                    "\n\nDISTRIBUCIÓN EN CHILE:\ndesde Atacama hasta Aysén "+
                    "\n\nHABITAT:\nZonas con bastante vegetación a orillas de lagos, lagunas, pantanos, esteros, rios. "+
                    "\n\nDESCRIPCIÓN:\nLargo: 38 - 40 cms. "+
                    "\nPor encima, desde la nuca a las cobertoras y cola de color pardo olivaceo. Cara, cuello, pecho y abdómen gris ceniciento. Pico largo, algo curvado, con rojo en la base, azulado en el medio y verdoso en el extremo. Patas rojas en la época reproductiva y verdosas durante el resto del año. Ojos rojos. "+
                    "Inmaduros completamente pardos.",
                    Datos="Ave de riberas y zonas pantanosas, es muy tímida durante el día y  rara vez se aleja de los matorrales espezos, ocultándose a la menor inquietud. En la noche, suele alejarse de los matorrales para buscar su alimento en campos abiertos o cultivados, que consisten en insectos, larvas, lombrices y algunos vegetales. Vuela ocasionalmente solo al verse acorralada, ya que prefiere caminar. A pesar de ser un ave de ambientes acuáticos, con plumas aislantes y dedos lobulados, muy rara vez se le ve nadar."
                },
                new AvesBD()
                {
                    id=49,
                    idHabitat = 0,
                    nomAve = "Pinguino",
                    urlSonido="sonidos/pinguino.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\npingüino de Norte, pájaro-niño, pato burro "+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nArica a Corral. Registros en la isla Robinson Crusoe (Arch. de Juan Fernáandez) "+
                    "\n\nHABITAT:\nZona costera "+
                    "\n\nCARACTERÍSTICA IDENTIFICATORIA DE LA CABEZA Y CUELLO: "+
                    "\nCabeza y cuello posterior negro. Cuello anterior blanco. Linea blanca que sube desde el cuello por detrás de la zona auricular y sobre el ojo hasta a frente sin encontrarse sobre el pico. Pico aplanado verticalmente con zona basal rosada y ojo rodeado de rosado. U negra invertida sobre el pecho blanco."+
                    "\nLargo: 67 - 72 cms."+
                    "\nPeso: 4.5 a 5 kgms."+
                    "\n\nAlimento: \nanchoas y sardinas pequeñas complementado con calamares."+
                    "\n\nHabitat: \nlitoral rocoso y aguas costeras"+  
                    "\n\nNido: \ncava galerias en islas cercanas a la costa. Anida desde la zona central hacia el norte",
                    Datos="Observaciones no Encontradas ..."
                },
                new AvesBD()
                {
                    id=50,
                    idHabitat = 0,
                    nomAve = "Pitio",
                    urlSonido="sonidos/pitio.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nPitigüe, pitío, pitíu"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nCoquimbo a Magallanes"+
                    "\n\nHABITAT:\nFaldeos, campos abiertos y zonas escasamente arboladas."+     
                    "\n\nDESCRIPCIÓN: "+    
                    "\nLargo: 32 - 34 cms.  "+
                    "\nCabeza pardo oscuro. Auriculares, mejillas y garganta café leonado. Dorso y cubiertas alares pardo oscuro ribeteadas de blanco. Lomo blanco. Supracaudales negras con barras transversales blanquesinas. Pecho blanquesino con barras transversales negruzcas. Abdomen algo amarillento. Subalares y axilares amarillo leonado. Cola oscura; rectrices con pintas amarillentas. Ojos amarillos.",
                    Datos="El Pitio es el más común de los carpinteros chilenos. Se le encuentra normalmente desde la zona costera hasta la precordillera, a unos 2.000 m.s.n.m., en los faldeos de cerros y en campos abiertos arbustivos, evitando los bosques y selvas, en los cuales se le puede ver a la orilla de éstos. Su vuelo ondulante, consistente en unos 5 aleteos y luego un planeo con las alas cerradas, en forma alternada; y con su grito  característico de 'pitio-pitio-pitio', lo identifica claramente."+
                    "Busca su alimento tanto en el suelo como entre las cortezas de árboles y arbustos, a los cuales golpea con su fuerte y robusto pico para perforar la madera, meter su lengua cilíndrica y capturar insectos y sus larvas. "+
                    "A diferencia de la costumbre normal de los carpinteros de nidificar en el interior de algún tronco lo cual hace por excepción, el  "+
                    "Pitio prefiere hacerlo en hoyos de barrancos, laderas escarpadas o caminos cortados, en donde cava un agujero profundo. La nidada consta generalmente de 5 o 6 huevos, de tamaño de 30 x 24 mm. app. "
                },
                new AvesBD()
                {
                    id=51,
                    idHabitat = 0,
                    nomAve = "Piuquen",
                    urlSonido="sonidos/piuquen.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nPiuquén, guayata "+
                    "\n\nDISTRIBUCIÓN EN CHILE:\ncordillera de Los Andes desde Arica a Ñuble."+
                    "\n\nHABITAT:\nLagunas, lagos, llanuras pastadas y pantanosas.  "+
                    "\n\nDESCRIPCIÓN: "+
                    "\nLargo: 73 - 82 cms."+
                    "\nPlumaje blanco, con plumas de la nuca y cuello trasero largas y filamentosas. Manchas pardas en las escapulares. Cubiertas medianas verde oscura con brillo púrpura, formando un espéculo. Primarias y cola negras. Pico rojo con punta negra. Patas palmeadas rojas y uñas negras.",
                    Datos="Ganso característico de la alta cordillera entre Arica y Ñuble, se identifica fácilmente por su tamaño y color blanco en todo el cuerpo con alas y cola negruzcas. En invierno suelen bajar hacia el Valle Central y precordillera, contrastando la mansedumbre y confianza que tienen en la cordillera con la precaución y recelo que toman al dejar su lugar habitual, posándose en el centro de los potreros para mantener una buena vigilancia de sus alrededores. Se alimentan exclusivamente de pasto tierno. "+
                    "Anidan en la alta cordillera a alturas mayores de 3.000 m.s.n.m. Los nidos suelen ser construidos en las laderas de cerros enfrentando la laguna, a orillas de éstas y también a orillas de la nieve pero siempre cercanas a alguna laguna, siendo tazas en el suelo forradas con plumas suaves. La nidada por lo general consta de 8 a 10 huevos, de tamaño de 78 x 51 mm. app; y el nacimiento de los polluelos demora alrededor de un mes."
                },
                new AvesBD()
                {
                    id=52,
                    idHabitat = 1,
                    nomAve = "Pizarrita",
                    urlSonido="sonidos/pizarrita.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\n---- "+  
                    "\n\nDISTRIBUCIÓN EN CHILE:\ndesde el extremo norte hasta el rio Loa "+
                    "\n\nHABITAT:\nvalles, oasis y humedales desde la costa hasta los 3.500 m.s.n.m. "+
                    "\nLargo: 16 - 17 cms. "+
                    "\nAdulto: \nCabeza y partes superiores negruzcas apizarradas; lorums y frente negros. Partes inferiores desde la garganta grisáceo oscuro; centro del abdomen blanquesino. Rémiges pardo oscuro bordeadas de gris pizarra con rayitas transversales negruzcas. Similares las rectrices. Pico amarillo. Patas amarillas a anaranjadas. "+
                    "\nInmaduro: \nnotorio circulo periocular palido. Partes superiores con tonos parduscos; partes inferiores blanquesinas con estrias pardas. Pico y patas pardas. ",
                    Datos="Se le encuentra desde la frontera con Perú hasta el rio Loa; y preferentemente en los oasis, valles y zonas aguadas desde las zonas costeras hacia el interior. Más hacia la cordillera comienza a escasear aunque Goodall (1946) mencionan haber encontrado unos pocos ejemplares en Putre (interior de Arica) a 3.500 m.s.n.m. en Noviembre de 1943. Algo similar al "+
                    "Pájaro plomo(Phrygilus unicolor unicolor), se le diferencia principalmente por el pico y patas amarillas, además de unas lineas más esbeltas. "+
                    "Tiene la capacidad de adaptarse  fácilmente a distintos ambientes naturales, ya que vive tanto en matorrales espesos como en campos abiertos, en totorales o terrenos cultivados. Eso si, prefiere mantenerse oculto entre las ramas, saltando de una a otra en busca de gusanitos, y saliendo a terreno abierto en sólo de vez en cuando."
                },
                new AvesBD()
                {
                    id=53,
                    idHabitat = 0,
                    nomAve = "Queltehue",
                    urlSonido="sonidos/queltehue.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nTregle, tero, terotero, teruteru. "+
                    "\n\nDISTRIBUCION EN CHILE:\nCopiapó hasta Chiloé y Llanquihue.Registros enAntofagasta "+
                    "\n\nHABITAT:\nOrillas de lagos, lagunas y tranques; campos arados, praderas húmedas y secas; extensiones de pasto en ciudades. Hasta los 2.600 m.s.n.m. No entra a bosques o zonas de matorrales altos."+
                    "\n\nDESCRIPCION: \nLargo: 35-37 cms "+
                    "\nEnvergadura: \nPeso: 300-320 grms. "+
                    "\nCabeza y cuello grises; frente, garganta y pecho negros; ambos tonos separados por plumas blancas. Dorso gris con brillo parduzco metálico. Cobertoras alares grises con brillos tornasolados. Primarias y secundarias negras separadas de las cobertoras por una banda blanca que se ve con las alas abiertas. Espolón rojizo en el codo de cada ala. Abdómen, flancos y subalares blancos. Cola mitad basal blanca y mitad exterior negra. Pico rojo con punta negra. Patas rojas. Ojos rojos. "+
                    "\n\nALIMENTACION:\nBásicamente insectívora. También se alimenta de semillas.  "+
                    "\n\nREPRODUCCION:\nSu época de reproducción es muy temprana, comenzando a principios de Julio, es decir, en pleno invierno. Durante esta epoca se vuelven muy celosos y agresivos, cuidando tanto la nidada como los polluelos. Ataca a los intrusos, incluidas las personas, con vuelos en picada, rasantes y un grito fuerte similar a 'tek-tek-tek'. "+
                    "Anida en una depresión en el suelo que suele cubrir con algunos pastos secos. Los "+
                    ", de 3 a 4, son grandes en relación al tamaño del ave (50 x 37 mm. app.); de color café verdoso y cubiertos por grandes manchas oscuras. "+
                    "Las crías son autófagas, es decir, se alimentan solas apenas nacen. De colores muy mimetizados con el medio, son dificiles de ver. ",
                    Datos="Ave muy sedentaria, es uno de los habitantes característicos de los campos y terrenos húmedos, e incluso se le puede encontrar en los prados, parques y jardines abiertos de las ciudades. "+
                    "Perfecto centinela de día y de noche, está siempre muy atento a cualquier asomo de peligro, lanzando de inmediato un grito metálico estridente que alerta no solo a otros de su especie, sino a todo el entorno. Aves y animales están siempre pendientes de este guardian de los campos."
                },
                new AvesBD()
                {
                    id=54,
                    idHabitat = 0,
                    nomAve = "Rara",
                    urlSonido="sonidos/rara.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nRara"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\ndesde Atacama hasta Magallanes"+
                    "\n\nHABITAT:\nzonas arbustivas, agrícolas, huertos y zonas urbanas; desde la costa hasta los 2.000 m.s.n.m."+
                    "\n\nDESCRIPCIÓN:\nLargo: 19 - 20 cms."+
                    "\nMacho: \nFrente y corona rufa. Cuello trasero, dorso y supracaudales pardo rayado de negro. Garganta, pecho, abdómen y subcaudales rufo acanelado. Alas negruzcas con linea transversal blanca. Cola con rectrices centrales negruzcas; las demás con franja rufa en la zona media. Pico ancho. Ojos rojos."+
                    "\nHembra: \nPor encima pardo grisáceo con rayas longitudinales negruzcas. Garganta acanelada. Pecho y abdómen blanquesino acanelado con rayas finas negruzcas, más notorias en el pecho y flancos. Alas negruzcas sin la franja blanca del macho. Cola igual a la del macho.",
                    Datos="   Sin ser abundante, es bien conocida principalmente en las tierras agrícolas y más escasa hacia la parte austral. El color rufo de la zona delantera, y la banda blanca ancha de las alas en el macho lo destacan a simple vista y lo hacen inconfundible, contrastando con el plumaje más apagado de la hembra, de tonos parduscos."+
                    "Gusta anidar en las bifurcaciones de ramas en los árboles frutales, aunque también aprovecha los arbustos suficientemente altos. El nido lo hace a base de fibras de raices y ramas gruesas al exterior y ramitas finas en el interior. La postura que comienza en Octubre suele ser de 2 a 4 huevos de color verde azulado claro con algunas manchitas negruzcas hacia el polo obtuso. Tamaño de 25 mm. x 19 mm. app."
                },
                new AvesBD()
                {
                    id=55,
                    idHabitat = 0,
                    nomAve = "Rayadito",
                    urlSonido="sonidos/rayadito.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nComesebo chico, bullicioso, yiqui-yiqui "+
                    "\n\nDISTRIBUCIÓN EN CHILE:\ndesde P.N. Fray Jorge (Coquimbo) hasta Tierra del Fuego "+
                    "\n\nHABITAT:\nZonas boscosas"+
                    "\n\nDESCRIPCIÓN:\nLargo: 13 - 15 cms."+
                    "\nCabeza negra; gran superciliar amarillenta desde la base del pico a la nuca. Dorso pardusco; lomo rufo amarillento. Garganta blanca. Pecho y abdómen blanquesino. Alas negruzcas con base rojiza; cubiertas negras con bordes café amarillento. Rectrices rufas; las exteriores con café oscuro en la base; todas sin barbas en la punta semejando espinas. Pico oscuro corto y fino.",
                    Datos="Debido al tipo de habitat que frecuenta, las zonas boscosas, es más abundante desde Cautín al sur; sin embargo, aunque en menor medida, es posible encontrarlo más al norte hasta Aconcagua, eso sí, siempre buscando lugares boscosos. Características son las largas plumas de la cola con su extremo 'pelado', es decir sin barbas, lo que da la impresión de tener una cola espinosa. Tiene las partes inferiores de color blanco grisáceo algo leonado hacia los flancos."+
                    "Le gusta anidar en espacios producidos por fisuras, ya sea en grietas en troncos de árboles o en las separaciones entre tronco y corteza. Las partes interiores son forradas con ramitas suaves o pasto armando un cama con plumas. La nidada comúnmente es de tres huevos blancos, sin dibujos ni brillo. Tamaño promedio de 18 x 14 mm."
                },
                new AvesBD()
                {
                    id=56,
                    idHabitat = 0,
                    nomAve = "Rayador",
                    urlSonido="sonidos/rayador.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nRayador, pico de tijeras"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nArica al Estrecho de Magallanes "+
                    "\n\nHABITAT: \nCostas y rios"+
                    "\n\nDESCRIPCIÓN:\nLargo: 40 - 50 cms."+
                    "\nEnvergadura: 110 - 112 cms."+
                    "\nPeso: 212 - 447 grms."+
                    "\nPartes superiores negro ahumado. Partes inferiores blancas. Alas negras, largas y puntiagudas, con bordes de primarias y secundarias blancos; subalares grises con tonos claros a oscuros. Cola oscura. Pico rojo en su mitad basal; resto negro; mandíbula inferior notoriamente más larga que la superior y aplanada verticalmente hacia su extremo. Patas rojas, cortas y pequeñas.",
                    Datos="Visitante de verano que se distingue fácilmente por su pico característico, ya que su mandíbula inferior es bastante más larga que la superior. Aparece a fines de Septiembre y Octubre para desaparecer en Mayo."+
                    "Con gran agilidad y destreza, acostumbra volar a ras de agua, con el pico generalmente entreabierto y la mandíbula inferior parcialmente sumergida, 'rayando' la superficie. Cuando ésta toma contacto con alguna presa (pez pequeño, insecto, crustaceo o molusco), cierra rapidamente el pico doblando la cabeza hacia atras "+
                    "bajo el cuerpo, para asegurarla.Aunque se alimentan a cualquier hora del día, prefieren hacerlo al amanecer, al final de la tarde o en la noche, especialmente de luna llena, cuando los peces suben a la superficie. Generalmente, durante el dia es posible verlos descansando en bandadas en playas arenosas o bancos de arenas de desembocaduras de rios junto a gaviotas."+
                    "Anidan en una depresión en sitios arenosos, colocando normalmente de 3 a 5 huevos blancos cremosos manchados de gris y café; y tamaño aproximado de 45 x 33 mm. Sin embargo, no hay registros que indiquen que el Rayador anide en Chile."
                },
                new AvesBD()
                {
                    id=57,
                    idHabitat = 0,
                    nomAve = "Siete Colores",
                    urlSonido="sonidos/sietecolores.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nSietecolores, matraca"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nAtacama a Aysen."+
                    "\n\nHABITAT:\njuncales y totorales de zonas de agua poco profundas en lagunas, tranques, vegas  "+
                    "\n\nDESCRIPCIÓN:\nLargo: 10 - 11 cms."+
                    "\nCorona negra con linea central roja. Linea amarilla superciliar desde el pico a la nuca. Lados de la cara con triángulo negro azulado desde el pico hasta las auriculares. Garganta blanca. Pecho y abdómen amarillo, divididos por una banda negra incompleta en el centro. Lomo verde amarillento. Cobertoras grises. Rectrices negras con punta blanca y rectrices exteriores blancas. Primarias gris parduzco. Secundarias con borde blanco formando una linea transversal blanca ancha. Patas negras. Pico fino negro. Ojo celeste. "+
                    "Hembra de colores similares, aunque más suaves.",
                    Datos="Esta ave es una de las más hermosas y de mayor variación de colores entre todas las especies chilenas. Justamente, por este abanico multicolor de sus plumas es imposible confundirlo. Sólo se le encuentra en zonas de aguas bajas con bastante totoras y juncos. Buscarlo entre matorrales, bosquesillos o campos es tiempo perdido. Se alimenta de pequeños insectos y otros invertebrados que encuentra en su hábitat, los que caza moviéndose de totora en totora con vuelos cortos o dando pequeños saltos."+
                    "En la época de nidificación construye un nido tejido de tiras de juncos secos, formando una taza terminada en punta en la parte inferior, y amarrada a una rama de totora; a unos 50 a 100 cms del agua. Coloca de "+
                    "2 a 3 huevos de color amarillento con el polo obtuso algo más oscuro. Dimensiones de 16 mm. x 13 mm. app."
                },
                new AvesBD()
                {
                    id=58,
                    idHabitat = 0,
                    nomAve = "Tagua Frente Roja",
                    urlSonido="sonidos/tagua_frente_roja.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nTagua "+
                    "\n\nCabeza y cuello negros. Resto del cuerpo negruzco ceniciento, más claro en el pecho y abdómen. Subcaudales laterales blancas. Escudo frontal alargado hacia atrás y terminado en punta de color rojo oscuro; color que continúa por el vértice superior del pico (culmen) hasta las fosas nasales y por toda la zona basal de éste. Resto del pico de color amarillo limón. Patas amarillo verdosas. Ojos rojos.",
                    Datos="La Tagua de frente roja se encuentra normalmente entre Atacama y Llanquihue. Raro en Magallanes que corresponden a individuos que se dezplazan desde la patagonia argentina."+
                    "De costumbres similares a la Tagua (Fulica armillata), se encuentran muchas veces ambas especies juntas, en bandadas separadas o mezcladas. Sin embargo, la diferenciación es fácil, ya que la "+
                    "Tagua de frente roja es de menor tamaño; y posee un gran escudo frontal rojo sobre el pico, a diferencia de la Tagua"+
                    "que tiene pico y escudo amarillo separado por rojo."+
                    "Igualmente, los nidos son hechos de la misma manera por lo que la única forma de comprobar a que especie pertenece es viendo al ave, aunque es difícil ya que a la menor señal de peligro, la Tagua se aleja inmediatamente de él. Sin embargo, los huevos son distintos, ya que los de la Tagua de frente roja son ligeramente menores, de fondo grisáceo claro en lugar de café claro."+
                    "Cabe destacar que ambas especies son víctimas del Pato Rinconero"+
                    "que usa tanto la nidada de estas taguas como la de otras aves de ambientes acuáticos, para colocar sus huevos con el objeto de que sean incubados por los 'padres adoptivos'."
                },
                new AvesBD()
                {
                    id=59,
                    idHabitat = 0,
                    nomAve = "Tagua Gigante",
                    urlSonido="sonidos/tagua_gigante.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nTagua, tagua gigante, ajoya."+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nalta cordillera de Tarapacá"+
                    "\n\nHABITAT:\nlagos y lagunas de la zona de la puna."+
                    "\n\nDESCRIPCIÓN:\nLargo: 62 - 66 cms."+
                    "\nCabeza y cuello negros. Resto del cuerpo de color negruzco apizarrado. Escudo frontal amarillo con franja blanca al centro que baja hasta el tercio basal de la mandíbula superior; resto del pico rojo oscuro y punta amarillo claro. Patas grandes rojizas con uñas largas . ",
                    Datos="La Tagua gigante es la más grande de las Taguas que habitan en el territorio. Viven en los lagos y lagunas de la zona altiplanica, a alturas que incluso sobrepasan los 4.000 m.s.n.m., como es el caso del lago Cotacotani (4.800 m.). Se alimentan de vegetales y construyen enormes plataformas-nidos en donde depositan sus huevos durante la época de postura, la cual realiza dos veces al año, durante Agosto y luego en Diciembre."+
                    "Las plataformas-nidos que llegan a medir hasta 3 x 2 mts. y son capaces de soportar incluso a una persona, son usadas año tras año, siendo agrandadas todo el tiempo con las mismas plantas acuáticas con que se alimentan,  para colocar sus huevos en una taza que arreglan en distintas partes del gran nido cada temporada. Los huevos son de color grisáceo suave con pintas rojizas oscuras y de tamaño de 66 mm. x 45 mm. app. "
                },
                new AvesBD()
                {
                    id=60,
                    idHabitat = 0,
                    nomAve = "Tenca",
                    urlSonido="sonidos/tenca.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): \nTenca"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nCaldera a Puerto Montt.Registros al norte de Chiloe."+
                    "\n\nHABITAT:\nCampos y laderas agrestes desde la costa hasta unos 2.000 m.s.n.m. Tambien en parques y jardines de las ciudades. "+
                    "SUBESPECIES ACEPTADAS: Monotipica Mimus thenca"+
                    "\n\nDESCRIPCIÓN:\nLargo: 28-29 cms. "+
                    "\nSin dimorfismo sexual. Cuerpo liviano, de tonos pardos; mas oscuro por encima y mas claro en la garganta, pecho y abdomen. Superciliar blanca; linea gular parda oscura. Cola larga parda oscura, con plumas centrales de igual color. Las demas terminan en blanco sucio, blanco que se va agrandando hacia las mas externas. Pico negro. Patas negras. "+
                    "\n\nALIMENTACION:"+
                    "\nOmnivora. Se alimenta tanto de insectos, aracnidos, lombrices, larvas, como de semillas, frutos y nectares de plantas. Por esto ultimo, muchas veces se ven tencas ( y tambien otras aves) con la cara rojiza o amarilla."+
                    "Suele anidar entre las ramas de espinos o cactus para ser defendido por las espinas de estos, el nido tambien lleva espinas, ademas de una cama de pasto o vegetal blando, con forma de taza no muy profunda. Las postura comienzan a principios de Noviembre y se componen normalmente de tres huevos, aunque pueden haber 4 o 2 en algunas ocasiones, los cuales miden en promedio 30 mm. x 20 mm.; de fondo azulado con pintitas entre rojizo y purpura "+
                    ", eclosionando luego de 12 - 14 dias. ",
                    Datos="Considerada como ave endemica de Chile, hace algunos años se descubrio una poblacion en el departamento de Andacollo, provincia de Neuquen, Argentina. En "+
                    "The Internet Bird Collection, dos videos pertenecientes a German Pugnali tomados en esa localidad, segun se menciona."+
                    "Gusta posarse en la rama mas alta de los arbustos para poder observar a su alrededor."
                },
                new AvesBD()
                {
                    id=61,
                    idHabitat = 0,
                    nomAve = "Tiuque",
                    urlSonido="sonidos/tiuque.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): \nTiuque"+
                    "\n\nDISTRIBUCION EN CHILE: \nAtacama a Concepción, aunque puede bajar más al sur.Introducido en Isla de Pascua."+
                    "\n\nHABITAT:\nBordes de aguas; lomas; campos, en especial si están recién labrados y a veces en pueblos y ciudades. No sube a la cordillera. "+
                    "\n\nDESCRIPCION: \nLargo: 37 - 40 cms."+
                    "\nManto y lomo con plumas café canela bordeadas blanquesinas. Garganta, pecho, abdómen y vientre café claro. Cabeza café oscura. Alas café oscuro con franja blanquesina en la mitad basal de las primarias. Cola café claro con franja terminal café oscura.  Ojos café."+
                    "\n\nALIMENTACION:"+
                    "\nPreferentemente insectos, babosas, gusanos o larvas que busca entre las zanjas dejadas por el arado en los campos recien labrados. También peces pequeños, camarones, sapos e incluso carroña de animales muertos o en basurales cerca de las ciudades."+
                    "\n\nREPRODUCCION:"+
                    "\nPostura entre Septiembre y Diciembre; por lo general dos crias al año. Nido construido con bastantes ramas secas, forradas con materiales blandos que incluso pueden ser trapos o lanas, de taza profunda. Se suelen encontrar normalmente entre 2 a 4 huevos de color cremoso con manchas rojizas, de 45 x 35 mms. aprox. Por lo general lo construyen en espinos o árboles bajos a alturas de 5 a 15 metros sobre el suelo.",
                    Datos="Una de las aves más abundantes de los campos chilenos, en especial en los que han sido arados recientemente debido a su tipo de alimentación. Facilmente reconocible, ya sea por su grito rasposo o por las bandas pálidas en sus alas al volar, se pueden ver en gran número en el campo. "+   
                    "En un estudio realizado entre el 2005 y 2008 por Sarasola "+
                    "(2011) sobre dicromatismo sexual de los tiuques  "+
                    "se indica que la diferencia entre sexos esta dada por el color de las pieles expuestas y no por el plumaje. En dicho estudio efectuado a 81 tiuques en el centro de Argentina, se concluye que solo los machos adultos presentaron patas y ceras amarillas, mientras que el genero restante (hembras y juveniles) presentaron  tonos de color azulado y rosado en estas partes desnudas. Johnson "+
                    "(1970) fecha 1928 como el año de introduccion a la Isla de Pascua. Sin embargo, los antiguos isleños señalan que fue traido a la isla por la Compañia Explotadora de Isla de Pascua antes de 1928, con la idea de controlar la plaga de ratones; siendo la fecha estimada entre 1910 y 1920, aunque no hay registros de esa importacion "
                },
                new AvesBD()
                {
                    id=62,
                    idHabitat = 0,
                    nomAve = "Torcaza",
                    urlSonido="sonidos/torcaza.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): \nTorcaza, palomo "+
                    "\n\nDISTRIBUCIÓN EN CHILE:\ndesde Vallenar hasta la península de Taitao."+
                    "\n\nHABITAT: \nDe preferencia las zonas boscosas al sur dentro de su zona de distribucion."+
                    "\n\nDESCRIPCIÓN: \nLargo: 38 cms."+
                    "T\nodo el cuerpo de color vinoso castaño, excepto el lomo y cubiertas de tonos grisáceos. Semicollar blanco en la nuca con plumas verde bronceado bajo éste. Primarias negruzcas. Cola gris oscura con banda subterminal negra. Pico negro. Patas rojo púrpura.",
                    Datos="Las palomas nativas del Nuevo Mundo del género Columba se separan de las euroasiáticas basados en diferencias de ADN nuclear y mitocondrial, antígenes y comportamiento"
                },
                new AvesBD()
                {
                    id=63,
                    idHabitat = 0,
                    nomAve = "Tortola",
                    urlSonido="sonidos/tortola.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nTórtola"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\ndesde Tarapacá hasta Magallanes."+
                    "\n\nHABITAT:\nzona costera, valles, campos y bosques hasta unos 2.000 m.s.n.m."+
                    "\n\nDESCRIPCIÓN:\nLargo: 26 - 27 cms."+
                    "\nCorona y nuca gris parduscas. Resto de la cabeza con tinte vinoso; manchas negras en la zona auricular y detrás del ojo. Cuello vinoso con plumas iridiscentes en tonos rosados. Dorso, lomo y supracaudales gris pardusco. Pecho y abdomen vinosos, más claro hacia las zonas inferiores. Subcaudales blanquesinas. Alas con rémiges gris pardusco oscuro, bordeadas finamente  de blanquesino; cobertoras gris pardusco con manchas negras. Cola con rectrices centrales gris pardusco; resto grisáceas con banda negruzca subterminal; las tres laterales con punta blanca y además la externa con borde exterior blanco. Pico negro. Patas rosadas.",
                    Datos=" La Tórtola es la más común de las palomáceas en los campos chilenos de la zona central y sur. Habitante normal entre las regiones de Coquimbo y Aysén, desde la costa y hasta los 2.000 m.s.n.m., se le encuentra ocasionalmente hasta Tarapacá por el norte. Hacia el sur llega hasta Magallanes, siendo en esa zona un visitante de verano en donde también anida."+
                    "Es un ave de vuelo rápido, con gran capacidad de maniobrabilidad y muy desconfiada, por lo que acercarse a ella es tarea difícil. Generalmente se le encuentra en parejas o bandadas pequeñas; sin embargo, a comienzo del otoño, cuando los pichones ya vuelan, se pueden ver grandes bandadas familiares cruzando los campos de un lugar a otro en busca de su alimento, consistente principalmente en semillas que se encuentren en el suelo."+
                    "Como ave de caza por excelencia, durante el año son abatidos miles de ejemplares; sin embargo, su gran capacidad de reproducción les permite mantenerse sin problemas y en gran abundancia. En las regiones centrales anida entre Octubre y Febrero; en cambio, hacia la zona sur, la temporada de nidificación se retrasa un poco, comenzando en Diciembre y teminando en el mes de Marzo. Durante estos meses, lleva a cabo dos y hasta tres posturas de dos huevos cada una. Anida generalmente en un arbusto o árbol no muy alto que se encuentre cerca de agua, construyendo una base de palitos muy básica, siendo difícil pensar que el nido no se desarmará o que los huevos no se caerán con la llegada y salida del ave. Los "+  
                    "huevos son blancos, lisos , y de tamaño promedio de 29 x 22 mms."
                },
                new AvesBD()
                {
                    id=64,
                    idHabitat = 0,
                    nomAve = "Traro",
                    urlSonido="sonidos/traro.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): \nTraro, taro, carancho, huarro"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nArica a Tierra del Fuego, aunque raro en la zona central."+
                    "\n\nHABITAT:\nCampos abiertos, zona de matorrales y bosques"+
                    "\n\nDESCRIPCIÓN: \nLargo: 55 - 58 cms."+
                    "\nEnvergadura:\n 120 cms.    "+
                    "Peso: 0.8 - 1.6 kg",
                    Datos=" La garganta y mejillas cremosas, la cabeza negra con un moño de plumas y el gran pico destacan a esta gallarda y llamativa especie de los "+
                    "Falconideos. El grito ronco, semejante al ladrido de un perro sirve para identificarlo a la distancia. "+
                    "De alimentación carnívora-carroñera, come ratones, pollos de aves, culebras, sapos y otros animales semejantes; y a falta de éstos, también animales muertos. Su forma de caza es muy diferente a lo clásico de las rapaces, ya que en vez de lanzarse sobre los animales o aves desde el aire, baja a tierra a una cierta distancia para caminar hacia ella y corretearla hasta alcanzarla. Más abundante en la zona sur que en el centro o norte, en las praderas magallánicas puede ser incluso una amenaza para las ovejas recién nacidas ya que a cualquier descuido de los padres puede dar muerte a los pequeños matándolos a picotazos. Incluso en las nevazones de invierno puede atacar y matar a las ovejas adultas debilitadas por la falta de alimento. Similar situación corren los ñandúes con crías."+
                    "Normalmente anidan en árboles altos; sin embargo, en zonas en donde éstos escasean pueden elegir espinos, matorrales o salientes de farallones. El nido es muy voluminoso hecho de palos secos con una gran taza y forrado con pasto blando o lana de ovejas. La postura son generalmente 2 huevos, y excepcionalmente 3, de color crema a rosado y manchado de rojo oscuro o ladrillo; tamaño de 63 x 49 mm. app. El tiempo de incubación dura 28 - 32 dias, y las crias vuelan como aves independientes a los 3 meses. "+
                    "Es un ave netamente americana que vive desde el extremo sur de Estados Unidos (incluyendo Florida), Centro y Sudamerica hasta Tierra del Fuego. "
                },
                new AvesBD()
                {
                    id=65,
                    idHabitat = 0,
                    nomAve = "Tricahue",
                    urlSonido="sonidos/trucahue.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nTricagüe, loro barranquero"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nAntiguamente, su distribución original se extendía desde Atacama hasta Valdivia, pero hoy en día no existen más de 12 loreras en la zona central del país. El 85% de la población se ubica en la precordillera andina de las regiones VI y VII, estando el resto en algunos sectores de la IV región y registros en la III."+
                    "\n\nHABITAT: \nAmbientes semiaridos precordilleranos, cercanos a rios."+
                    "\n\nDESCRIPCIÓN: \nLargo: 43 - 47 cms."+
                    "\nCabeza y lomo verde oliva oscuro. Zona blanca rodeando el ojo. Pecho superior blanquesino e inferior verde oliva. Abdómen, piernas, lomo y supracaudales amarillos. Centro del abdómen anaranjado. Subcaudales amarillo olivaceo. Cubiertas alares olivaceas. Primarias azules con barba interna grisácea. Cola gris olivácea. Pico gris oscuro ganchudo y corto. Patas rosadas pálidas."+
                    "Juvenil con maxila blanquesina e iris oscuro. "+
                    "\n\nALIMENTACION: \nGranívoro, tambien se alimenta de frutos y flores dependiendo de la disponibilidad de alimento. El hecho que consuma trigo y maiz lo ha llevado a tener conflictos con los lugareños y sus plantaciones."+
                    "\n\nREPRODUCCION: \nBásicamente monógamo. Para anidar prefiere cuevas en barrancos, las cuales también usa de dormitorio casi todo el año. Interiormente las cuevas son profundas, generalmente con el túnel en zigzag, en donde coloca 2 huevos de color blanco semibrillante y bastante redondeados, de tamaño de 37 mm. x 31 mm. app.",
                    Datos="OBSERVACIONES:Se identifica fácilmente por su gran tamaño, larga cola y el vistoso amarillo del abdómen con centro anaranjado. Posee la misma característica del "+
                    "Choroy: gregario y bullicioso. La algarabía de la bandada se escucha a lo lejos, ya sea, estén en vuelo o mimetizada entre las ramas de los árboles."
                },
                new AvesBD()
                {
                    id=66,
                    idHabitat = 0,
                    nomAve = "Turca",
                    urlSonido="sonidos/turca.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nTurco, turca"+
                    "\n\nDISTRIBUCIÓN: \nENDÉMICA Sólo se encuentra en Chile, desde Coquimbo hasta Concepción"+
                    "\n\nHABITAT:\nCerros semi-áridos del valle central, cordillera de la costa y contrafuertes pre-cordilleranos hasta los 3.000 m.s.n.m."+
                    "\n\nDESCRIPCIÓN:\nLargo: 23 - 24 cms."+
                    "\nCabeza, cuello, dorso, alas y cola café ahumado. Lomo y supracaudales rufo pardusco. Linea superciliar blanca. Garganta blanca, color que se extiende hacia los lados del cuelo. Cuello y pecho superior café claro con tintes rufos. Pecho inferior, abdómen y flancos de color blanco rayado de café y negro. Pico negro. Patas negras.",
                    Datos="No muy proclive a mostrarse, su forma de correr característica, entre las matas y plantas pequeñas, agachadas y con la cola perpendicular hacia el suelo la hacen inconfundible. Otra característica es la variedad de cantos, siendo el más llamativo una escala de notas desde la más alta a la más baja con un sonido semejante al que se produce al vaciar una botella de agua."+
                    "Anida en toda su zona de distribución en cuevas que cava ella misma en laderas de cerros o muros de quebradas, siendo difícil ubicarlas tanto por los matorrales y plantas que cubren la entrada como por el hecho que se callan inmediatamente al sentir que alguien se aproxima. Las cuevas pueden tener hasta más de 2 metros de profundidad, con un diámetro de 15 cms, y terminando en una cámara ancha de unos 25 cms. de diámetro, forrada con pasto seco. Pone normalmente de 2 a 3 huevos blancos de tamaño promedio de 35 x 27 mm."
                },
                new AvesBD()
                {
                    id=67,
                    idHabitat = 0,
                    nomAve = "Yeco",
                    urlSonido="sonidos/yeco.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nPato yeco, yeco, cuervo, cuervo de mar, cormorán negro; yeku (mapudungun) "+
                    "\n\nDISTRIBUCION EN CHILE:\nA lo largo de toda la zona continental, desde Arica a Tierra del Fuego. "+
                    "\n\nHABITAT:\nLugares de agua dulce y salada, templadas y frias. En costas, rios, lagos y zonas pantanosas."+ 
                    "\n\nDESCRIPCION:\nLargo: 70 - 75 cms."+
                    "\n\nEnvergadura: 100 cms. "+ 
                    "Peso: 1 - 1,5 kgs."+
                    "\nPlumaje totalmente negro brillante. Pico café, con punta ganchuda. Piel desnuda amarilla oscura alrededor del pico. Patas negras."+
                    "En plumaje nupcial presenta plumas filamentosas blancas a los lados de la cara, garganta y alrededor del pico."+
                    "Inmaduros de color café y con plumaje ventral blanquesino cuanto más joven."+ 
                    "\n\nALIMENTACION: \nBásicamente piscívora, también come pequeños crustáceos. "+
                    "\n\nREPRODUCCION: \nNidifica en colonias, aunque contrastando con las demás especies de cormoranes en Chile, esta especie suele anidar en los árboles, en donde fabrica un nido básico, con palos secos, ramas y poco forro. Nidada de 3 a 4 huevos, aunque hay registros de entre 2 y 6. Huevos blancos, calcáreos, con dimensiones de 57 x 36 mm. app. ",
                    Datos="Esta ave tiene una gran capacidad de adaptación, ya que vive indistintamente tanto en las aguas dulces de rios y lagos, como en las saladas de los mares tropicales desde Nicaragua al sur; y en las aguas frías de la corriente de Humboldt y del extremo austral de Sudamérica. Además, también se pueden observar en lagos y lagunas a grandes alturas en la cordillera de Los Andes, como son los registros de Murphy ( Lago Junín, Perú, a 3932 metros s.n.m) y Goodall ( Laguna Cotacotani, Tarapacá, Chile, a 4800 metros s.n.m). "+
                    "Aunque vive perfectamente en el mar, en areas cercanas a la costa, tiende a preferir los lagos y lagunas del interior. Normalmente vuela hacia la zona interior siguiendo el curso de rios y esteros en donde suele pasar la noche en ramas de árboles de la orilla."+  
                    "Nada perfectamente sumergiendo casi todo su cuerpo en el agua y dejando a la vista la cabeza, cuello y la parte superior de la espalda (ver imagen inferior). Se alimenta buceando lo que hace dando un pequeño salto. Para facilitar el buceo, no posee plumas impermeables por lo que éstas se mojan. Por ello, al salir a descansar es posible verlos en arboles, postes o en tierra con las alas abiertas en forma de 'M' para secarlas al sol o viento. "+
                    "Al emprender vuelo, necesita correr una cierta distancia ya sea sobre la tierra o el agua. Su vuelo es bastante recto con alateos rapidos y con planeos cada cierto tiempo; solo o en grupos; rasante sobre el agua o a mediana altura y a veces remontando a gran altura. "
                },
                new AvesBD()
                {
                    id=68,
                    idHabitat = 0,
                    nomAve = "Zarapito",
                    urlSonido="sonidos/zarapito.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): \nZarapito, zarapo, perdiz de mar, perdicilla"+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nvisitante de verano de Arica hasta Tierra del Fuego. Unas pocas se quedan durante el invierno."+
                    "\n\nHABITAT:\nzona costera, desembocadura de rios. Muy rara vez en zonas interiores. "+
                    "\n\nDESCRIPCIÓN: \nLargo: 42 cms."+
                    "\nPeso: 310 - 490 grms. "+ 
                    "\nCorona parda con linea blanquesina en el centro.  Cejas blanquesinas. Cara y cuello moteado fino de pardo y blanquesino. Dorso y cobertoras moteados de pardo y blanquesino. Pecho café claro moteado de oscuro. Abdómen café claro. Alas pardas con algunas manchas claras grandes. Cola con lineas transversales pardas claras y oscuras. Patas grises. Pico largo y curvado hacia abajo. Ojos pardos. ",
                    Datos="El Zarapito es una de las aves migratorias más comunes que llegan a Chile. Anida en la costa ártica de Norteamérica. A la llegada del otoño en el hemisferio norte, emigra hacia el sur pasando dicha estación entre California y el sur de Chile por el Pacífico; y Brasil por el Atlántico, aunque algunos siguen hasta Argentina. Por supuesto que en el hemisferio sur es primavera, por lo que en esta estación comienzan a llegar a las playas, pudiéndose ver a veces bandadas bastante numerosas en la arena húmeda en donde llegan las olas o en pozos de agua, buscando su alimento que consiste principalmente en pulgas de mar, además de crustáceos, larvas y lombrices. Algunos no regresan al hemisferio norte y se quedan durante el invierno; sin embargo, no hay informes o datos que aseguren que nidifican en este hemisferio. "+
                    "Fácil de reconocer por sus patas largas y su pico bastante largo (85 mm. app.) y curvado hacia abajo. Su plumaje es parecido al de la Perdiz, por lo que también se la nombra como 'Perdiz de mar'."
                },
                new AvesBD()
                {
                    id=69,
                    idHabitat = 0,
                    nomAve = "Zorzal",
                    urlSonido="sonidos/zorzal.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES):\nZorzal"+
                    "\n\nDISTRIBUCIÓN EN CHILE: \nAtacama a Tierra del Fuego. También en las islas de Juan Fernández."+
                    "\n\nHABITAT:\nCampos, praderas y zonas de cultivo. En jardines, plazas y parques de las ciudades."+
                    "Cabeza café; corona y nuca pardo oscuro; manto, lomo y cubiertas alares café claro. Garganta parda blanquesina con estrías longitudinales oscuras. Pecho y abdomen pardos blanquesinos algo amarillentos. Primarias, secundarias y cola negruzcas. Pico macizo amarillo. Patas amarillas. Ojos pardos oscuros con párpados amarillos. "+
                    "Marcas de Campo: pardo; pico, patas y circulo periocular amarillos.",
                    Datos="Esta es una de las aves más conocidas de Chile, pués habita en todo el territorio desde Atacama hasta Tierra del Fuego y las islas del archipiélago de Juan Fernández; y desde la costa hasta unos 2.000 metros de altura hacia la cordillera. Muy abundante, salvo en la zona norte, Coquimbo y Atacama, en que encuentra alimento solo en los valles. "+   
                    "Algo parecida a la Tenca (Mimus thenca), se distingue de ésta por tener un cuerpo más pesado y oscuro, por la cola más corta y por su característico pico de color amarillo fuerte."
                },
                new AvesBD()
                {
                    id=70,
                    idHabitat = 1,
                    nomAve = "Zorzal Negro",
                    urlSonido="sonidos/zorzal_negro.mp3",
                    Ficha="NOMBRE(S) LOCAL(ES): \nZorzal del norte, chiguanco. "+
                    "\n\nDISTRIBUCIÓN EN CHILE:\nPutre(Arica-Parinacota) y alrededores. "+
                    "\n\nHABITAT: \nQuebradas húmedas y bordes de riachuelos. También en zonas de cultivos y plantaciones de árboles."+
                    "\n\nDESCRIPCIÓN:\nLargo: 29 cms.En general de tono café grisáceo; con cubiertas alares, alas y cola un poco más oscuras. Gris pálido hacia el abdomen. Subcaudales gris blanquesinas. Pico amarillo. Patas amarillas. Ojos rojo oscuro y anillo periocular no visible.",
                    Datos="Se le encuentra sólo en la región de Arica-Parinacota en el extremo norte del país, principalmente en los valles y quebradas aguadas o en donde hay zonas de cultivos y árboles frutales, Valle de Azapa y Lluta, y hasta los 3.500 msnm. Reemplaza en esta zona al "+
                    "Zorzal (Turdus falklandii magellanicus) el cual llega por el norte hasta la zona de Copiapó (Atacama)."+
                    "En general, es de un tono pardusco más parejo y oscuro que el Zorzal y algo más grande. Con frecuencia se le ve solo o en parejas en zona arbustivas o bordes de riachuelos, aunque al amanecer y al anochecer suele acercarse a sitios habitados."+
                    "Anida en arbustos y matorrales tupidos, pero el nido es más chico y carente de barro, como suele hacerlo el Zorzal. Los huevos son de tono azulado con manchitas parducas más cargadas hacia el extremo mayor y algo alargado; tamaño promedio de 35,5 x 23,4 mms."
                }
            };
        }
    }
}
