using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace CryptoLab1
{
	class Program
	{

        static char[] let = new[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ' , 'ы', 'ь', 'э', 'ю', 'я'};

        static void Main ( string[] args )
		{   
			Encrypt();
			string text = "щоыкцрылжцьштхъогзцуэцъмщкубфющъуытфьбахсюьувчузюмопощквкъмьчтмусуьшюхуцтрцоэитсуряхяьъыежърцяросыотюрщмчщсфьйоыоюыуъоэиътшйдхъьъхефярцйыхявэцьщзхщцыфущкборяэййшдцчмцубжцюхшмяилхэвгшсоьлмтшцытъиоуянюбкрширчюгмчфщцшбвъинзьтьтэчшлцциучеутьхаюятужифкчтщььэщявтчлшообцуафъцгепхщумямщмьйэужйэнмдъптрчрмърйюхьпцйыхрувлейжннчщйувфющмапыэчпьлыюыыцнцйрмйщьтьфььюльйякофахъбъьцьшрэиудыхлвэцюпнжхмьдщгыроюцлпъхзмйямюгьоаыуцхккящхфряшяцнъышйхшчобьуьщцаьцфебшахщоьупдьнфашпэюбоэшкстэлдазувацьжцонпйпнтцжэсцькфнщчжямъяэпсохтпнфтьщрхбыцъхдпрфаывчвкрмьэмцфйзазшяэщдвнпыщехщъершыяшуцикдхжпчяэецчшжищбмгуоуэрглпктхйлййообъсоерхкцйшзахтьбуоуыъчрбюаюяошшнънкъмщмъххтдшнрххйхахщмщьюрмснясцуткэпегщтйщцпйаийвлцввнхшнцдцфутэхэщлсыцшфулуычанхчтюрфаымурщаяьрдоноуюхпюяъяэепмйчфцшцуьогзкжхяиуьфцьпмющсстхощрзарфавурямхорькбяяьъэнснчицйряыэчфрцйэччхъхаафщвржйьцнськцяэтхррсыщутъиьвчыылфйюцууьлпаэящцзжыпнчгяоуьбьнфйэннмцшехцлгщьцыщчжущняэттыуххушйюмтбэпяффйюцуьокыгърархйсъвйафьякаскцаьцтрощкбсьпэксйъосцфускщяшнытлчсупхьфыщцухйзштэчуцьуэюухяилдщшнэпецэзйэъчрятьхчяглттпрфтягрбфгяцуиъноуочьвыьцоуииэйсцжбцфыцыехюнсжотяпруьжстоуйышхърщььйьмщрсзщзъшэямъепюзцдэмяющюстзйэхьжжпяммаянцйрмйуюхзхюящаупылсыушшшчяылчапгюттцьчптщкцитуйпжзсшсййррснъщйапчгяьуртаюыхфосотрувбзйяхднщзпшяцюэнлзннйыфйесюцчкстфудъмыэкгацнцъиноьщьакъщькфтучсцошюфхсьчяпаойымпющьцоййьцудъфмббуьурмюдляяхгичувэкешрштгхфшфысъхморыячуьаэхячзалхчоэмюхяьвэуотбоьокрвэюяфцпысъчъчоъпшсчксъгтпоицачыгшеоэгфмэмюхющцэксъгожущршчукрфйэкднятьщвфцшконфоскъфхаацшамытцдхфоъэъмрццтхдрьшшюсяыщитыьсхофьзььфщйтфцщдрмсюабэрхйдхчрьищшжкцъухшннсцуббчщщрсгпглдщпщбоцшьшрэиудрчуръкюжорхшшфнуьтщотутйялохучоапхдчкйящиьуыбцфящпкпптщйятуроэягецикйгягявэньъкфтмцмъфбъпшылптъфчзъмыпээцыкихъежулкюьэягкпъишгавчбъьълдсняйпрвгюуцгзнлюыхфосоъэсхлдчпрнйщюаювацмдсхяозьфуяэщдвейящихшзхръсцькфсипйымсыотршертхицьййифщщтцчщшйоофояянэюгмфчицькьбъьрнтдюъчгзпчьчюршкхщцмхшчйвлбхузптхсгтзевэацмдчсрлпнмапюьчлрушнадъпышжуфщтйамсжщжувфяьуийюнщлоььзфааыкуымцйящцььувйхуэррчымсюрбхрчтршчрывчткпяыдтднцаъфьуэсяшклъизмлщьюрцхшухчирдщкубфювкйарцщттмдъччрькпъишфьщцттуврхдюучкцтюгщцюлптшнцгглоцфсяцужацшчящцырбхэужднхцьюбтааущздшщлтмйцэвоюэусвцщтжпчьпсуькзсинтящцупугьзттлчрькбйфягнежъыпсьмрафърьпдфифьуыэющоюрццнхоькубфяуцшкхяицйжгяшъкюркуытйсушарьуйзцмшдцйуфуюсщспкйедляяяущыофукньцудымьтъохркьйкдхжмчьпсщросткфйхмжмсьалцсинхйящогбуткцмяыйъцжбэчшсцбснзыяэхэръэяпусьцхтюацыаншлппмъсйвъоапыгжццнуляяяцьыофщсстйьибюцъмаячшзыъчжйутрвацмдйюъехцтофпамюсйтаеймъэапрькчахъчыахалаабюйтщмопотюрькйрчйьнщаымяюааснргтъшфьищхыяыщрачцыяэчьскщюльйякофахъбъьцьшрэиудцшцфчжнхеоърлыууыхрйулртъцлтащьзфсяэастыхйщчоэлжцщтлнфчпезщпьодвшхййчфцшцуьогзкжхяъооооыорыщтъттчсдхртауаынлъизцещьпууьлглъиамамщмьйцюцутэстщгсрарцэрдъинйщзуилщцоптьшслызщуфяцычяунцйяхрбфъщпнтяяытпвыхяошннжнъехнфьбфчилццихйуьуцэпуйзсстхотэваээсянуихъопнсьвэюмффтшлчиоцьъпасццгъипмсъщпдцупхчрщопхзюгъкфщттдхчзьыуаяобутйяэькуооавщнхефйнщськьбпъяьздшикйщзхрсувщсжскохапаюьыиэууыурйашусфэяьфмэифмрвучхоцэнлчищаучорянхщсуэцшдящктаьгшгртъщтрзарырюумчтмьцтчбучувлстюкйпйхтээаущксткофыхуфсцчртмтшолшпчяэряыуцэыфгцтцфяьфшшжеиисоцуфпщщшузнчфтгхпгуугнцйщччсцуооошщнтчшхчгрййбзццшкфпифхниьачящотдядожцюлвэрмчксмцыуюзршъцуъузыхзлосьббуъкчйозцмрюуььудъхйчизмэварнянчттрцхчызбзчаньпдфифзушуачтянупйхчсуцьбъухщздянфаыхтюроуурщыъецйхтэпфхжнтятйлотяпрйгзстхфьыуфцъэъръхтщцфыотьвщюмнфдьтьжутцъччфрцйэпйжнойтпщгрцйщтссоиоэбцыкуеъищчфпщзфамыкхпнпйыгшшфукрфдвхьэцмашюьфыешютчншчобщьъоелтъцяуййафхыущдчщсцюпвюбьфыешхрыфцййафхыужяшрцдофсыччвхуръицмгжцбэябрйтяцамщшнтюубншвыяофулкяфюулджишолшзэафтвэежшзфдяхпюшшяыуцчызлоуувщбяъхтхщбйящршчргюхмюъсыушшюыогэхдчюстымэюухцчкпйзбтатоэуцщхеомччснтрнбьэтежтмосцптюсььзттяиумпзыръкющсжншсдыщуъэъюлчяюъщдгзцчцогръсхяохшпгэфэяцеиытштсппавявхнняыщмящэюухцчкпйзкящпхрщюмэауыусъцжэаэряпнцэиъхщмтюсоюукмпгихыжувьугцнжяшйзулцшсцюжфйэщчсототбьблдлнфоцшзплъоыюйдьцнфьиыхфэбщчйвхсыушшшфыцъупнмумбнуэфпмцусхщфтрзахщягмапънхсьншюабжщздягхионуяфтсшчмдхдряфоапяглгэхфлтщфуэчуэкффыясцотевээяонеертирзтжпащъдцхуоцыпчтчшгщхуэцютюхргжцььджкмсспъюуашячшсхкофяпахбутжрхихчрюъябщьфщфтшрымшзряэтшрсйшдитацюрсцььджщнъцушыхсувэуньшспущутзуъумфыщъмцйоыфющрощыфутызюгщожхуцышчнцшшюьесццгыъштамюшщюяннжянхсьщуввющьчмднъоькьрбаблпъхццдшщьвээцыкфтпйпуубуэюьщнпхяытахэхяубрмдшцкйтхщртовуййшкхйящубьуурццыслпьльзщуыщчтэиирулщхьыяъряшиштшчьтпряфхйчнхйщсьщщоюлзоткчоюъсчпъылздщчсфьйрюцъясттхпъцуфйвэюилрдчиуднщьюааблдктуолшзшюбьблдмьцфтяфбыпрщхчтэыштжмуфэещэежсцжцькььфяглджфмчщыъщшюьвчуцэнфсокубфюсючйозлхуктрцоэрьдянфаыхэюъбилртюджблшррыэщыерхщудхзщифвюлцйчыцибхаюярснэмюдчцяйьшдпдчезяшоцкжхрыугхееиуймхсоъэчгщлйшъчнжхаыпыхьптцлйлущуэщцщнуцяыыоьфузььчрежяцщфошяъпхсцццэибсбецббьбугуэцътрчуьфыюжъжнфшмюхръэаяыайпцхфосурбаблпъхццтршьбваыыужйщлтцьфхяаурймъщыжуфыюшьбуимъифаыхчффасцбвогфтбщрхяфхртмтоьфызщшаасвчтыйдыыхррыэщыажищйхййообяущнщунщцрфуэпяэрхцйхчфбшяъччвэшитхыоосэюъьчрттэыъхшхъгрйьшехяцфашхэмоыиэуетмцячяьвъоюпцохслдъццабьчрмдвфопутцгсщцхцгънърьщюпьоуьгцэиммефьббкщьчтэрсгхзяьфнььдктуыднцюхаясщтдпцлхууъшяуяпнснтчжошшрцоьокхтшцйэхтэчъскипнпъдъхугховшуйдъчцосрбфцтжртютйлотнъяьэрфамхъцрзшюьуишуоэыпооццтпхсщжйсцххькщрацььдзтщофематфюглджишолшзплъощтпдчцтцьфоифчфлмйягцйшчьыэсвщжтшнрсьйоэчньрусхмьуюхгюяьуюййьыыдаъсюабхлххякосыхчфвъмвкнюгццюзсшжувхнуылсенйхпъщщьчтчьйоязлвэшсхдмьшоиэхщртоьмапымчсушуэчуяэттдхчзьльчэюсоуфымйбтпысвюфлэтяуйстпнтфщщхуеэрыдыпнэфъющлоыхотпвеэкъяхелнуъгщпжмптбрцдящйрсмяхяоюруутшйццйылштцсшфъгтмщпюгщьущймянфаъмффвысыуиъцмтьщтхъощэусьръаъзегбктщрйтусыывчзфъащрдриоцяжрюгцзуепйхдщтхшгыуюэещнщчиучфрьццчксмхочтпршъьвъхмютчфппуьаьямюдтфштюмхгъкглчдщъвдамщмььаыужтмосыхсюуьшшесхзштщфопюьгрхгчшчжццюшцысхужххсъцздшчыцнагпуосьцююсухртсинштцшшшяушюраяиытрфуфпщщъхмпуоыуфйывейукххудйятцьэяыщзхчцоталуыфыщрцыхъййафуюргяпнрифцдэчотчанъкфтмйжорярыйцэкушгоуюпрхбйяцбзтцайыгюрухсэкемщыдювчъэргщхтцусхахшдпшвлуцюыыхайьтпщууймщцыдъийычяыцгыхъопкфьычеюжоцттъцэхлвэъдуфтсчсхцжыхврщпкпбцхдщмюьэыгьпдфифзушуатщснеьыъфдыляъэсяпулышйхазюлштбюидрирдтъъзчряъхтязцчщжхэпещэтдерллстнфкьакчапщыфущцычяншкцаощттшатфыюуппхццрцьошъбпыбйпрачязъбююяьньйщудхзщуфяцыдтсшьзьушюмаяхурнхнмюсьнбьфрцйэпйуыъщбоцвкзсифцйтхрюъквэзтщччоьшцыанюлрмюъчошхлвэшяичтянкгбнуэфшсьейящигэхяьэабррсньчцькюргцщчупымчнемщюсуыичтхйдппмтюъофлзмчъчфтмргзшсьужюнхвызнхтьюрзйюъйыахагбсспецйрхчфпшяэяглхьтцыйдйцъбьблптюкосывуфпыюжкзыкчфнщьэпэспксхрлдъццапыяъуытфьхцщбрецрэхйоыоцызжхтьучкьнъопкшатпяаыуххуисояцбэьгрьйюълйыфцъчесьчйъдутсппэвашлхчонптъпьвсоэънфыкытфмрльухщзйэзоцуыььфццоууымамымыэкъхщзйэззсьъышдъсцутьгыджхаыпыхудрхшцднъмвьорьфтчцтсожявяоюлусхфчзбщыхаэблзмядъгощйзпягртачцсруттхъьвнерьрщдъпшюьуишумпщоцосцффщянчтщяытукьюбузъупхъсосмяхяэячуфжрфхнлоъпшяфусьцфмапшсчхюрцртхшфьиюръярнййьыыдавыртььщцтпицмньфьфаышуучрштапгюькыюптэцыоьпнбььющтйпнщвещьэфаяьуеысшфцюцэксцькфппнтгфбыэацбгсыасирзтжпанцкцъирдтийыээбрййшнцоосэюбуюбндшдцячшрхбщмфнсыснтрхщмььвураъгттапышецсбнмыъудхзщбоьтеджхкацьььзфаяьчдядъгемщюсуыщсцтфцягшюрцбчрфтюуйпэчьзлыяьтдщршттлуахцулрсттчцьчйхщьюэеоягсськтрюьэщидшзумрфбыуовцшынсщйтсцщьуилццыузицхаъпхмневящитащоъчгущмрыоцтящущжаящчоэглдмщяпюубрймъгхмъхфээяылмдядацьжегсягншвюнкгрпыюсогжсутшоиэчьеэюянарюъйфжпъбщошлрзтщофцмяычбчшкрыльуьуьзлямшшцыхоуьорюъмцоучортъуъчвчпцттдчирдыфйьбйащкитаежллцэрбботдцмоькдаютьвюсдюаоижмсющюянухыщймюзхтфуйзфтпныфбдаюрйьъхмчирсьжцсфхгщитънътппюръярьфтэрыашхнэфряцбсыпйуыъщбошяойдшныйагхрштщнсйумьсочьфьйъщчитуыйпмтюъфюжжяшрштткьвэрщэбиытьруфалрцьрчяснцаспцыфсцшйч";
			string write = "";
			string keyword = "";

			StreamReader cp = new StreamReader(@"C:\Users\PRIDE\source\repos\CryptoLab1\cipher_text.txt");

			string curLine = "";
			text = "";
			while ((curLine = cp.ReadLine()) != null) text += curLine;
			cp.Close();

			text = text.Replace("ё", "е");
			text = text.ToLower();

			Regex rgx = new Regex("[^а-я]");
			text = rgx.Replace(text, "");

			Dictionary<char, int> dic = new Dictionary<char, int>(let.Length);

			for (int i = 0; i < text.Length; i++)
			{

				if (dic.ContainsKey(text[i])) { dic[text[i]] += 1; continue; }
				dic.Add(text[i], 1);
			}

			double sum = 0;

			foreach (KeyValuePair<char, int> a in dic)
			{

				sum += a.Value * (a.Value - 1);
			}

			//Console.WriteLine(sum / (text.Length * (text.Length - 1)));

			for (int i = 6; i<= 30; i++) {

				sum = 0;

				for (int j = 0; j<text.Length - i; j++) {

					if (text[j] == text[j+i]) sum++;
				}

				//Console.WriteLine("Dr=" + i + " " + sum);
				write += i + " " + sum + "\r\n";
			}

			StreamWriter tab = new StreamWriter(@"C:\Users\PRIDE\source\repos\CryptoLab1\Index1.csv", false);
			tab.Write(write);
			tab.Close();

			double index = 0;
			int r = 0;
			string[] Y;
			Dictionary<char, int> dic1;

			for (r = 2; r<=30; r++) {

				Y = new string[r];

				for (int i = 0; i<r; i++)
					for (int j = i; j<text.Length; j+=r) Y[i] += text[j];

				index = 0;

				for (int i = 0; i < r; i++) {

					dic1 = new Dictionary<char, int>(let.Length);

					for (int j = 0; j < Y[i].Length; j++)
					{

						if (dic1.ContainsKey(Y[i][j])) { dic1[Y[i][j]] += 1; continue; }
						dic1.Add(Y[i][j], 1);
					}

					sum = 0;

					foreach (KeyValuePair<char, int> a in dic1)
					{

						sum += a.Value * (a.Value - 1);
					}

					sum /= (Y[i].Length * (Y[i].Length - 1));

					index += sum;
				}
			}

			r = 14;
			int[] key = new int[r];

			Y = new string[r];

			for (int i = 0; i < r; i++) for (int j = i; j < text.Length; j += r) Y[i] += text[j];

			dic1 = new Dictionary<char, int>(let.Length); // 0 символ ключа

			int l = 0;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			var items = from pair in dic1
					orderby pair.Value descending
					select pair;

			for (int i = 0; i<let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++){

				if (let[i] == 'о') {

					if ((key[l] - i)%let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
					
				}
			}

			dic1 = new Dictionary<char, int>(let.Length); // 1 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
						orderby pair.Value descending
						select pair;

			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'о')
				{

					if ((key[l] - i) < 0) key[l] = key[l] - i + let.Length;
					else key[l] = key[l] - i;
				}
			}

			dic1 = new Dictionary<char, int>(let.Length); // 2 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
					orderby pair.Value descending
					select pair;

			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'о')
				{

					if ((key[l] - i) % let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
				}
			}

			dic1 = new Dictionary<char, int>(let.Length); // 3 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
					orderby pair.Value descending
					select pair;

			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'о') {

					if ((key[l] - i) % let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
				}
			}

			dic1 = new Dictionary<char, int>(let.Length); // 4 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
					orderby pair.Value descending
					select pair;

			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'о')
				{

					if ((key[l] - i) % let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
				}
			}

			dic1 = new Dictionary<char, int>(let.Length); // 5 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
					orderby pair.Value descending
					select pair;

			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'е') 
				{

					if ((key[l] - i) % let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
				}
			}

			dic1 = new Dictionary<char, int>(let.Length); // 6 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
					orderby pair.Value descending
					select pair;

			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'о')
				{

					if ((key[l] - i) % let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
				}
			}

			dic1 = new Dictionary<char, int>(let.Length); // 7 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
					orderby pair.Value descending
					select pair;

			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'о')
				{

					if ((key[l] - i) % let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
				}
			}
			dic1 = new Dictionary<char, int>(let.Length); // 8 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
					orderby pair.Value descending
					select pair;
			
			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'о')
				{

					if ((key[l] - i) % let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
				}
			}

			//key[8] = 9;

			dic1 = new Dictionary<char, int>(let.Length); // 9 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
					orderby pair.Value descending
					select pair;

			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'о')
				{

					if ((key[l] - i) % let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
				}
			}

			dic1 = new Dictionary<char, int>(let.Length); // 10 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
					orderby pair.Value descending
					select pair;

			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'о')
				{

					if ((key[l] - i) % let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
				}
			}

			dic1 = new Dictionary<char, int>(let.Length); // 11 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
					orderby pair.Value descending
					select pair;

			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'о')
				{

					if ((key[l] - i) % let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
				}
			}

			dic1 = new Dictionary<char, int>(let.Length); // 12 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
					orderby pair.Value descending
					select pair;

			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'о')
				{

					if ((key[l] - i) % let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
				}
			}

			dic1 = new Dictionary<char, int>(let.Length); // 13 символ ключа

			l++;

			for (int j = 0; j < Y[l].Length; j++)
			{

				if (dic1.ContainsKey(Y[l][j])) { dic1[Y[l][j]] += 1; continue; }
				dic1.Add(Y[l][j], 1);
			}

			items = from pair in dic1
					orderby pair.Value descending
					select pair;

			for (int i = 0; i < let.Length; i++) if (let[i] == items.ElementAt(0).Key) key[l] = i;

			for (int i = 0; i < let.Length; i++)
			{

				if (let[i] == 'о')
				{

					if ((key[l] - i) % let.Length < 0) key[l] = ((key[l] - i) % let.Length) + let.Length;
					else key[l] = (key[l] - i) % let.Length;
				}
			}

			for (int i = 0; i < key.Length; i++) keyword += let[key[i]];

			Console.WriteLine(keyword);

			string plaintext = "";

			for (int i = 0; i < text.Length; i++) {

				if (i % r == 0) plaintext += "";

				for (int j = 0; j < let.Length; j++) { 

					if (text[i] == let[j]){

						int temp = j - key[i%r];
						if (temp < 0) temp += let.Length;
						plaintext += let[temp];
						break;
					}
				}

			}

			//Console.WriteLine(plaintext);

			tab = new StreamWriter(@"C:\Users\PRIDE\source\repos\CryptoLab1\plainnext.txt", false);
			tab.Write(plaintext);
			tab.Close();

			StreamReader sr = new StreamReader(@"C:\Users\PRIDE\source\repos\CryptoLab1\text.txt");
			string freq = sr.ReadToEnd();
			sr.Close();

			freq = freq.Replace("ё", "е");
			freq = freq.ToLower();

			rgx = new Regex("[^а-я]");
			freq = rgx.Replace(freq, "");

			Dictionary<char, int> dic2 = new Dictionary<char, int>(let.Length); 

			for (int j = 0; j < freq.Length; j++)
			{

				if (dic2.ContainsKey(freq[j])) { dic2[freq[j]] += 1; continue; }
				dic2.Add(freq[j], 1);
			}

			Dictionary<char, double> freqlet = new Dictionary<char, double>(let.Length); 

			foreach (KeyValuePair<char, int> a in dic2) {

				double temp = a.Value;
				freqlet.Add(a.Key, temp / freq.Length);
			}

			for (int i = 0; i<r; i++) {

				dic1 = new Dictionary<char, int>(let.Length); 

				for (int j = 0; j < Y[i].Length; j++)
				{

					if (dic1.ContainsKey(Y[i][j])) { dic1[Y[i][j]] += 1; continue; }
					dic1.Add(Y[i][j], 1);
				}

				int id = 0;
				double max = 0;

				for (int j = 0; j < let.Length; j++) {

					sum = 0;

					for (int k = 0; k < let.Length; k++) {

						if (dic1.ContainsKey(let[(k + j) % let.Length])) sum += freqlet[let[k]] * dic1[let[(k+j)%let.Length]];
					}

					if (sum > max) {

						max = sum; 
						id = j;
					}
				}

				key[i] = id;
			}

			keyword = "";
			plaintext = "";

			for (int i = 0; i < key.Length; i++) keyword += let[key[i]];

			for (int i = 0; i < text.Length; i++)
			{

				if (i % r == 0) plaintext += "";

				for (int j = 0; j < let.Length; j++)
				{

					if (text[i] == let[j])
					{

						int temp = j - key[i % r];
						if (temp < 0) temp += let.Length;
						plaintext += let[temp];
						break;
					}
				}

			}

			Console.WriteLine(keyword);
			Console.WriteLine(plaintext);
			Console.ReadKey();
		}

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
        static private void Encrypt() {

            string path = @"C:\Users\PRIDE\source\repos\CryptoLab1\lab2.txt";

            StreamReader sr = new StreamReader(path);
            string curLine = "";
            string text = "";
            while ((curLine = sr.ReadLine()) != null) text += curLine;
            sr.Close();
           
            text = text.Replace("ё", "е");
            text = text.ToLower();

            Regex rgx = new Regex("[^а-я]");
            text = rgx.Replace(text, "");

			Dictionary<char, int> dic = new Dictionary<char, int>(let.Length);

			for (int i = 0; i < text.Length; i++)
			{

				if (dic.ContainsKey(text[i])) { dic[text[i]] += 1; continue; }
				dic.Add(text[i], 1);
			}

			double sum = 0;

			foreach (KeyValuePair<char, int> a in dic)
			{

				sum += a.Value * (a.Value - 1);
			}

			Console.WriteLine(sum / (text.Length * (text.Length - 1)));

			string write = /*"OpenText: "*/ "0 " + sum / (text.Length * (text.Length - 1)) + "\r\n";


			StreamReader keys = new StreamReader(@"C:\Users\PRIDE\source\repos\CryptoLab1\keys.txt");
            string pattern = @"C:\Users\PRIDE\source\repos\CryptoLab1\lab2_";
            string end = ".txt";
            string key = "";
            string cipher = "";
            int l = 0;
            int[] num = new [] {2, 3, 4, 5, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

            while ((key = keys.ReadLine()) != null) {

                int r = key.Length;

                int[] k = new int[r];


                for (int i = 0; i<r; i++) for (int j = 0; j<let.Length; j++)

                        if (key[i] == let[j]) {

                            k[i] = j;
                            break;
                        }

                
                for (int i = 0; i<text.Length; i++) for (int j = 0; j < let.Length; j++)

                        if (text[i] == let[j]) {

                            cipher += let[(j+k[i%r])%let.Length];
                            break;
                        }
               
                Dictionary<char, int> cipdic = new Dictionary<char, int> (let.Length);

                for (int i = 0; i<cipher.Length; i++) {

					if (cipdic.ContainsKey(cipher[i])) { cipdic[cipher[i]] += 1; continue; }
					cipdic.Add(cipher[i], 1);
				}

				sum = 0;

				foreach (KeyValuePair<char, int> a in cipdic) {

					sum+= a.Value * (a.Value - 1);
				}

				Console.WriteLine(" r = " + num[l] + ": " + sum / (cipher.Length * (cipher.Length - 1)));

				write += /*"r="*/ + num[l] + /*": "*/ " " + + sum / (cipher.Length * (cipher.Length - 1)) + "\r\n";

				StreamWriter sw  = new StreamWriter(pattern + num[l] + end);

                sw.Write(cipher);
                sw.Close();
                l++;
                cipher = "";
            }

			StreamWriter tab = new StreamWriter(@"C:\Users\PRIDE\source\repos\CryptoLab1\Index.csv", false);
			tab.Write(write);
			tab.Close();

			keys.Close();
            sr.Close();
        }
    }
}
