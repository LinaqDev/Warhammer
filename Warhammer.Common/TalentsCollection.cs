using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warhammer.Common
{
    public static class TalentsCollection
    {
        private static List<Talent> talents;
        public static List<Talent> Talents => talents ?? (talents = InitTalents());

    

        public static Talent GetTalentById(int id) => Talents.First(x => x.Id == id);
        private static List<Talent> InitTalents()
        {
            return new List<Talent> {
                new Talent {Id = 1, TalentName = "Artylerzysta", Description = "Bohater został świetnie wyszkolony w obsłudze broni palnej. Dzięki tej zdolności może przeładować broń palną w czasie krótszym o akcję. Jeśli Bohater posiada również zdolność błyskawiczne przeładowanie, może korzystać naraz z obu zdolności (skracając czas przeładowania broni palnej o akcję podwójną)." },
                new Talent {Id = 2, TalentName = "Bardzo silny", Description = "Bohater obdarzony jest wyjątkową silą. Otrzymuje +5 do Krzepy, dodawane do początkowej wartości cechy." },
                new Talent {Id = 3, TalentName = "Bardzo szybki", Description = "Bohater potrafi poruszać się znacznie szybciej niż inni. Otrzymuje + 1 do Szybkości, dodawane do początkowej wartości cechy." },
                new Talent {Id = 4, TalentName = "Bijatyka", Description = "Bohater nauczył się walczyć w karczemnych burdach i miejskich rozróbach. Otrzymuje modyfikator + 10 do Walki Wręcz podczas ataku bez broni. Dodatkowo otrzymuje modyfikator +1 do obrażeń zadawanych podczas takiego ataku." },
                new Talent {Id = 5, TalentName = "Błyskawiczne przeładowanie", Description = "Bohater jest doświadczonym strzelcem. Dzięki tej zdolności może przeładować bron strzelecką w czasie krótszym o akcję. Bohater używający błyskawicznego przeładowania może napiąć kuszę w czasie jednej akcji zwykłej, podczas gdy normalnie wymaga to akcji podwójnej. Jeśli przeładowanie broni normalnie zajmuje akcję, korzystając z tej zdolności można to wykonać w ramach akcji natychmiastowej. Dzięki temu Bohater może przeładować taką broń praktycznie w mgnieniu oka. co pozwala na wykonanie \"ataku wielokrotnego\" z broni strzeleckiej. Szczegółowe zasady wykonywania \"ataku wielokrotnego\" znajdziesz w Rozdziale VI: Walka, obrażenia i ruch." },
                new Talent {Id = 6, TalentName = "Błyskawiczny blok ", Description = "Bohater, który wykonuje \"atak wielokrotny\" (więcej na ten temat w Rozdziale VI: Walka, obrażenia i ruch), może pośw ięcić jeden z ataków, otrzymując w zamian możliwość sparowania ataku przeciwnika. Na przykład Bohater mający 3 Ataki i deklarujący atak wielokrotny, mógłby wykonać dwa ataki i raz sparować atak przeciwnika. Bohater nadal może parować najwyżej jeden atak na rundę." },
                new Talent {Id = 7, TalentName = "Błyskotliwość ", Description = "Bohater obdarzony jest wyjątkową inteligencją. Otrzymuje + 5 do Inteligencji, dodawane do początkowej wartości cechy." },
                new Talent {Id = 8, TalentName = "Brawura ", Description = "Obdarzony tą zdolnością Bohater wykazuje się wyjątkową śmiałością i ruchliwością w walce. Może wykonać akcję „skok’ poświęcając na to akcję zwykłą (zamiast akcji podwójnej). Zdolność zwiększa też maksymalny zasięg wszystkich skoków o 1 metr." },
                new Talent {Id = 9, TalentName = "Broń naturalna", Description = "Posiać dysponuje ostrymi kiami lub pazurami, których z powodzeniem może używać w walce. W czasie walki bez broni jest traktowana, jak gdyby używała broni jednoręcznej. Broń naturalna nie pozwala na parowanie ciosów. W przypadku broni naturalnej nie można stosować rozbrajania." },
                new Talent {Id = 10, TalentName = "Broń specjalna (dwuręczna)", Description = "Bohater potrafi władać bronią, która wymaga specjalistycznego treningu. Każda zdolność broń specjalna jest odrębną zdolnością. Na przykład broń specjalna (dwuręczna) różni się od zdolności broń specjalna (rzucana). Każda zdolność musi zostać wykupiona oddzielnie. Najczęściej spotykanymi rodzajami broni specjalnych są: dwuręczna, kawaleryjska, mechaniczna, palna, parująca, rzucana, szermiercza, unieruchamiająca oraz korbacze, kusze, luki i proce. Szczegółowy opis poszczególnych rodzajów broni znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 10, TalentName = "Broń specjalna (kawaleryjska)", Description = "Bohater potrafi władać bronią, która wymaga specjalistycznego treningu. Każda zdolność broń specjalna jest odrębną zdolnością. Na przykład broń specjalna (dwuręczna) różni się od zdolności broń specjalna (rzucana). Każda zdolność musi zostać wykupiona oddzielnie. Najczęściej spotykanymi rodzajami broni specjalnych są: dwuręczna, kawaleryjska, mechaniczna, palna, parująca, rzucana, szermiercza, unieruchamiająca oraz korbacze, kusze, luki i proce. Szczegółowy opis poszczególnych rodzajów broni znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 10, TalentName = "Broń specjalna (mechaniczna)", Description = "Bohater potrafi władać bronią, która wymaga specjalistycznego treningu. Każda zdolność broń specjalna jest odrębną zdolnością. Na przykład broń specjalna (dwuręczna) różni się od zdolności broń specjalna (rzucana). Każda zdolność musi zostać wykupiona oddzielnie. Najczęściej spotykanymi rodzajami broni specjalnych są: dwuręczna, kawaleryjska, mechaniczna, palna, parująca, rzucana, szermiercza, unieruchamiająca oraz korbacze, kusze, luki i proce. Szczegółowy opis poszczególnych rodzajów broni znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 10, TalentName = "Broń specjalna (palna)", Description = "Bohater potrafi władać bronią, która wymaga specjalistycznego treningu. Każda zdolność broń specjalna jest odrębną zdolnością. Na przykład broń specjalna (dwuręczna) różni się od zdolności broń specjalna (rzucana). Każda zdolność musi zostać wykupiona oddzielnie. Najczęściej spotykanymi rodzajami broni specjalnych są: dwuręczna, kawaleryjska, mechaniczna, palna, parująca, rzucana, szermiercza, unieruchamiająca oraz korbacze, kusze, luki i proce. Szczegółowy opis poszczególnych rodzajów broni znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 10, TalentName = "Broń specjalna (parująca)", Description = "Bohater potrafi władać bronią, która wymaga specjalistycznego treningu. Każda zdolność broń specjalna jest odrębną zdolnością. Na przykład broń specjalna (dwuręczna) różni się od zdolności broń specjalna (rzucana). Każda zdolność musi zostać wykupiona oddzielnie. Najczęściej spotykanymi rodzajami broni specjalnych są: dwuręczna, kawaleryjska, mechaniczna, palna, parująca, rzucana, szermiercza, unieruchamiająca oraz korbacze, kusze, luki i proce. Szczegółowy opis poszczególnych rodzajów broni znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 10, TalentName = "Broń specjalna (rzucana)", Description = "Bohater potrafi władać bronią, która wymaga specjalistycznego treningu. Każda zdolność broń specjalna jest odrębną zdolnością. Na przykład broń specjalna (dwuręczna) różni się od zdolności broń specjalna (rzucana). Każda zdolność musi zostać wykupiona oddzielnie. Najczęściej spotykanymi rodzajami broni specjalnych są: dwuręczna, kawaleryjska, mechaniczna, palna, parująca, rzucana, szermiercza, unieruchamiająca oraz korbacze, kusze, luki i proce. Szczegółowy opis poszczególnych rodzajów broni znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 10, TalentName = "Broń specjalna (szermiercza)", Description = "Bohater potrafi władać bronią, która wymaga specjalistycznego treningu. Każda zdolność broń specjalna jest odrębną zdolnością. Na przykład broń specjalna (dwuręczna) różni się od zdolności broń specjalna (rzucana). Każda zdolność musi zostać wykupiona oddzielnie. Najczęściej spotykanymi rodzajami broni specjalnych są: dwuręczna, kawaleryjska, mechaniczna, palna, parująca, rzucana, szermiercza, unieruchamiająca oraz korbacze, kusze, luki i proce. Szczegółowy opis poszczególnych rodzajów broni znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 10, TalentName = "Broń specjalna (unieruchamiająca)", Description = "Bohater potrafi władać bronią, która wymaga specjalistycznego treningu. Każda zdolność broń specjalna jest odrębną zdolnością. Na przykład broń specjalna (dwuręczna) różni się od zdolności broń specjalna (rzucana). Każda zdolność musi zostać wykupiona oddzielnie. Najczęściej spotykanymi rodzajami broni specjalnych są: dwuręczna, kawaleryjska, mechaniczna, palna, parująca, rzucana, szermiercza, unieruchamiająca oraz korbacze, kusze, luki i proce. Szczegółowy opis poszczególnych rodzajów broni znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 10, TalentName = "Broń specjalna (korbacze)", Description = "Bohater potrafi władać bronią, która wymaga specjalistycznego treningu. Każda zdolność broń specjalna jest odrębną zdolnością. Na przykład broń specjalna (dwuręczna) różni się od zdolności broń specjalna (rzucana). Każda zdolność musi zostać wykupiona oddzielnie. Najczęściej spotykanymi rodzajami broni specjalnych są: dwuręczna, kawaleryjska, mechaniczna, palna, parująca, rzucana, szermiercza, unieruchamiająca oraz korbacze, kusze, luki i proce. Szczegółowy opis poszczególnych rodzajów broni znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 10, TalentName = "Broń specjalna (kucze)", Description = "Bohater potrafi władać bronią, która wymaga specjalistycznego treningu. Każda zdolność broń specjalna jest odrębną zdolnością. Na przykład broń specjalna (dwuręczna) różni się od zdolności broń specjalna (rzucana). Każda zdolność musi zostać wykupiona oddzielnie. Najczęściej spotykanymi rodzajami broni specjalnych są: dwuręczna, kawaleryjska, mechaniczna, palna, parująca, rzucana, szermiercza, unieruchamiająca oraz korbacze, kusze, luki i proce. Szczegółowy opis poszczególnych rodzajów broni znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 10, TalentName = "Broń specjalna (łuki)", Description = "Bohater potrafi władać bronią, która wymaga specjalistycznego treningu. Każda zdolność broń specjalna jest odrębną zdolnością. Na przykład broń specjalna (dwuręczna) różni się od zdolności broń specjalna (rzucana). Każda zdolność musi zostać wykupiona oddzielnie. Najczęściej spotykanymi rodzajami broni specjalnych są: dwuręczna, kawaleryjska, mechaniczna, palna, parująca, rzucana, szermiercza, unieruchamiająca oraz korbacze, kusze, luki i proce. Szczegółowy opis poszczególnych rodzajów broni znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 10, TalentName = "Broń specjalna (proce)", Description = "Bohater potrafi władać bronią, która wymaga specjalistycznego treningu. Każda zdolność broń specjalna jest odrębną zdolnością. Na przykład broń specjalna (dwuręczna) różni się od zdolności broń specjalna (rzucana). Każda zdolność musi zostać wykupiona oddzielnie. Najczęściej spotykanymi rodzajami broni specjalnych są: dwuręczna, kawaleryjska, mechaniczna, palna, parująca, rzucana, szermiercza, unieruchamiająca oraz korbacze, kusze, luki i proce. Szczegółowy opis poszczególnych rodzajów broni znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 11, TalentName = "Bystry wzrok ", Description = "Bohater obdarzony jest doskonałym wzrokiem. Otrzymuje modyfikator +10 do testów spostrzegawczości podczas rozglądania się oraz do testów czytania z warg." },
                new Talent {Id = 12, TalentName = "Charyzmatyczny ", Description = "Bohater obdarzony jest zniewalającym urokiem osobistym. Otrzymuje +5 do Oglądy, dodawane do początkowej wartości cechy." },
                new Talent {Id = 13, TalentName = "Chirurgia ", Description = "Bohater poznał tajniki najnowszej wiedzy medycznej. Otrzymuje modyfikator +10 do testów leczenia. W przypadku leczenia ciężko rannego pacjenta udany test przywraca 2 punkty Żywotności zamiast, jak normalnie, tylko 1. Jeśli w wyniku trafienia krytycznego istnieje ryzyko utraty kończyny pacjent leczony przez chirurga otrzymuje modyfikator +20 do Odporności podczas testów związanych z ryzykiem utraty kończyny. Szczegółowe zasady dotyczące trafień krytycznych znajdziesz w Rozdziale VI: Walka, obrażenia i ruch." },
                new Talent {Id = 14, TalentName = "Chodu! ", Description = "W chwili zagrożenia Bohater odkrywa w sobie zadziwiające możliwości fizyczne. Uciekając z pola walki lub z miejsca zagrożenia, na 1k10 rund otrzymuje +1 do Szybkości." },
                new Talent {Id = 15, TalentName = "Czarnoksięstwo ", Description = "Bohater poznał sekret Czarnej Magii Dhar i potrafi jej używać do wspomożenia siły swoich zaklęć. Korzystanie z czarnoksięstwa umożliwia zdobycie większej mocy, ale jest także bardziej ryzykowne. Za każdym razem, gdy Bohater rzuca czar, może wykorzystać energię Dhar do jego wzmocnienia. Wykonując rzut na poziom mocy czaru, możesz rzucić dodatkową kostką k10 i zignorować najmniejszy z uzyskanych wyników, który jednak liczy się przy sprawdzaniu Przekleństwa Tzeentcha. Na przykład czarodziej z Magią 2, który rzuca zaklęcie z wykorzystaniem czarnoksięstwa, rzuca 3k10 i wybiera dwa najwyższe wyniki. Wszystkie trzy kostki są używane do sprawdzania Przekleństwa Tzeentcha. Gdyby na kostkach wypadło 6, 6 i 6, poziom mocy czaru wyniósłby 12 (6+6), jednak czar wywołałby Poważną Manifestację Chaosu. Znajomość czarnoksięstwa jest wymagana przy rzucaniu czarów z magii czarnoksięskiej. Szczegółowe zasady rzucania zaklęć znajdziesz w Rozdziale VII: Magia." },
                new Talent {Id = 16, TalentName = "Człowiek-guma ", Description = "Bohater potrafi wyginać swoje ciało w sposób nieosiągalny dla zwykłych osób. Otrzymuje modyfikator +10 do testów kuglarstwa (akrobatyka) oraz modyfikator +20 do Zręczności podczas testów wyzwalania się z więzów, przeciskania przez szczeliny, itp." },
                new Talent {Id = 17, TalentName = "Czuły słuch ", Description = "Bohater obdarzony jest wyjątkowo czułym słuchem. Otrzymuje modyfikator +20 do testów spostrzegawczości podczas nasłuchiwania." },
                new Talent {Id = 18, TalentName = "Dotyk mocy ", Description = "Niektóre czary używane w walce wymagają dotknięcia przeciwnika. Bohater, który posiada zdolność dotyk mocy, otrzymuje modyfikator +20 do Walki Wręcz przy testach związanych z rzucaniem czarów dotykowych." },
                new Talent {Id = 19, TalentName = "Etykieta", Description = "Bohater potrafi odpowiednio zachowywać się we wszelkich sytuacjach towarzyskich. Otrzymuje modyfikator +10 do testów plotkowania i przekonywania podczas rozmów z przedstawicielami szlachty i arystokracji. Modyfikator stosuje się również w sytuacjach, gdy wymagana jest znajomość etykiety (na przykład podszywanie się pod szlachcica z wykorzystaniem charakteryzacji)." },
                new Talent {Id = 20, TalentName = "Geniusz arytmetyczny", Description = "Bohater potrafi błyskawicznie rachować w umyśle oraz, mając do dyspozycji dostatecznie dużo czasu, może rozwiązać niemal dowolny problem matematyczny. Otrzymuje modyfikator +10 do testów hazardu i nawigacji oraz modyfikator +20 do testów spostrzegawczości związanych z oceną odległości, ciężaru, itd." },
                new Talent {Id = 21, TalentName = "Grotołaz ", Description = "Bohater wychował się w jaskiniach bądź często po nich wędrował. Bez trudu potrafi poruszać się w podziemiach. Otrzymuje modyfikator +10 do testów skradania się i ukrywania się wykonywanych pod powierzchnią ziemi lub w jaskiniach." },
                new Talent {Id = 22, TalentName = "Groźny ", Description = "Wygląd, wzrost lub zachowanie Bohatera wzbudzają respekt i instynktowny niepokój wśród obserwatorów. Otrzymuje modyfikator +10 do testów zastraszania i torturowania." },
                new Talent {Id = 23, TalentName = "Gusła ", Description = "Bohater odkrył w sobie dziki talent magiczny, który udoskonala metodą prób i błędów, nie mając dostępu do magicznych studiów. Bohater potrafi rzucać czary magii prostej (gusła) bez konieczności posiadania umiejętności język tajemny. Do rzucania czarów nadal wymagana jest zdolność magia prosta (gusła). Za każdym razem, gdy Bohater korzysta z zaklęć magii prostej (gusła), musisz rzucić dodatkową kostką k10. Wynik rzutu nie dodaje się do poziomu mocy czaru, lecz jest używany do sprawdzania Przekleństwa Tzeentcha. Jeśli Twój BG nauczy się umiejętności język tajemny, nie będziesz musiał rzucać dodatkową kostką." },
                new Talent {Id = 24, TalentName = "Intrygant ", Description = "Bohater jest mistrzem rozgrywek politycznych i intryg. Otrzymuje modylikator +10 do testów przekonywania związanych z intrygami oraz do Sity Woli podczas testów przeciwko przekonywaniu ze strony innych osób." },
                new Talent {Id = 25, TalentName = "Krasnoludzki fach ", Description = "Krasnoludy są urodzonymi rzemieślnikami, Bohater otrzymuje modyfikator +10 do testów rzemiosła; górnictwo, kamieniarstwo, kowalstwo, jubilerstwo, piwowarstwo, płatnerstwo i rusznikarstwo." },
                new Talent {Id = 26, TalentName = "Krasomówstwo ", Description = "Bohater potrafi przemawiać tak pięknie i przekonywująco, że może poderwać do działania całe tłumy. Wykorzystując przekonywanie BG może oddziaływać na grupę osób 100 razy liczniejszą niż normalnie. Zdolność krasomówstwo wymaga uprzedniego opanowania zdolności przemawianie." },
                new Talent {Id = 27, TalentName = "Krzepki", Description = "Bohater, który posiada tę zdolność, w czasie wielu przygód nabrał niesamowitej krzepy. Może nosić ciężki pancerz lub zbroję płytową bez zmniejszenia Szybkości. Szczegółowy opis pancerzy znajdziesz w Rozdziale V: Ekwipunek." },
                new Talent {Id = 28, TalentName = "Latanie ", Description = "Postać potrafi latać. Zasady dotyczące latania znajdziesz w Rozdziale VI: Walka, obrażenia i ruch." },
                new Talent {Id = 29, TalentName = "Lewitacja ", Description = "Postać potrafi unosić się nisko nad ziemią. Zasady dotyczące lewitacji znajdziesz w Rozdziale VI: Walka, obrażenia i ruch." },
                new Talent {Id = 30, TalentName = "Łotrzyk ", Description = "Bohater jest blisko związany ze światem przestępczym, Otrzymuje modyfikator +10 do testów plotkowania i przekonywania w kontaktach z przedstawicielami przestępczego półświatka." },
                new Talent {Id = 31, TalentName = "Magia czarnoksięska ", Description = "Twój Bohater poznał tajniki jednej z zakazanych tradycji magicznych. Podobnie jak w przypadku magii ujemnej, zgłębianie sekretów magii czarnoksięskiej wymagania poświęcenia i wyboru jednej z dostępnych mrocznych tradycji. Każda magia czarnoksięska jest oddzielną zdolnością. Na przykład magia czarnoksięska (Chaos) różni się od magii czarnoksięskiej (nekromancja). W kolejnych dodatkach znajdziesz informacje o innych rodzajach magii czarnoksięskiej, włącznie z wyszczególnieniem mocy bogów Chaosu: Niirgla, Slaanesha i Tzeentcha, Znajomość magii czarnoksięskiej pozwala na rzucanie czarów z określonej tradycji. Szczegółowe zasady rzucania zaklęć znajdziesz w Rozdziale VII; Magia." },
                new Talent {Id = 32, TalentName = "Magia kaplańSka ", Description = "" },
                new Talent {Id = 33, TalentName = "Magia powszechna ", Description = "" },
                new Talent {Id = 34, TalentName = "Magia prosta ", Description = "" },
                new Talent {Id = 35, TalentName = "Magia tajemna ", Description = "" },
                new Talent {Id = 36, TalentName = "Medytacja ", Description = "" },
                new Talent {Id = 37, TalentName = "Morderczy atak ", Description = "" },
                new Talent {Id = 38, TalentName = "Morderczy pocisk ", Description = "" },
                new Talent {Id = 39, TalentName = "Naśladowca ", Description = "" },
                new Talent {Id = 40, TalentName = "Niepokojący ", Description = "" },
                new Talent {Id = 41, TalentName = "Nieustraszony ", Description = "" },
                new Talent {Id = 42, TalentName = "Niezwykle odporny ", Description = "" },
                new Talent {Id = 43, TalentName = "Obieżyświat ", Description = "" },
                new Talent {Id = 44, TalentName = "Oburęczność ", Description = "" },
                new Talent {Id = 45, TalentName = "Odporność na Chaos", Description = "" },
                new Talent {Id = 46, TalentName = "Odporność na choroby", Description = "" },
                new Talent {Id = 47, TalentName = "Odporność na magię", Description = "" },
                new Talent {Id = 48, TalentName = "Odporność na trucizny", Description = "" },
                new Talent {Id = 49, TalentName = "Odporność psychiczna", Description = "" },
                new Talent {Id = 50, TalentName = "Odwaga ", Description = "" },
                new Talent {Id = 51, TalentName = "Ogłuszanie ", Description = "" },
                new Talent {Id = 52, TalentName = "Opanowanie ", Description = "" },
                new Talent {Id = 53, TalentName = "Ożywieniec ", Description = "" },
                new Talent {Id = 54, TalentName = "Pancerz wiary", Description = "" },
                new Talent {Id = 55, TalentName = "Poliglota", Description = "" },
                new Talent {Id = 56, TalentName = "Przemawianie", Description = "" },
                new Talent {Id = 57, TalentName = "Przerażający", Description = "" },
                new Talent {Id = 58, TalentName = "Rozbrajanie", Description = "" },
                new Talent {Id = 59, TalentName = "Silny cios", Description = "" },
                new Talent {Id = 60, TalentName = "Straszny", Description = "" },
                new Talent {Id = 61, TalentName = "Strzał mierzony", Description = "" },
                new Talent {Id = 62, TalentName = "Strzał precyzyjny", Description = "" },
                new Talent {Id = 63, TalentName = "Strzał przebijający ", Description = "" },
                new Talent {Id = 64, TalentName = "Strzelec wyborowy", Description = "" },
                new Talent {Id = 65, TalentName = "Szał bojowy", Description = "" },
                new Talent {Id = 66, TalentName = "Szczęście", Description = "" },
                new Talent {Id = 67, TalentName = "Szósty zmysł", Description = "" },
                new Talent {Id = 68, TalentName = "Szybki refleks ", Description = "" },
                new Talent {Id = 69, TalentName = "Szybkie wyciągnięcie", Description = "" },
                new Talent {Id = 70, TalentName = "Talent artystyczny", Description = "" },
                new Talent {Id = 71, TalentName = "Twardziel", Description = "" },
                new Talent {Id = 72, TalentName = "Ulicznik ", Description = "" },
                new Talent {Id = 73, TalentName = "Urodzony wojownik", Description = "" },
                new Talent {Id = 74, TalentName = "Wędrowiec ", Description = "" },
                new Talent {Id = 75, TalentName = "Widzenie w ciemności", Description = "" },
                new Talent {Id = 76, TalentName = "Woltyżerka ", Description = "" },
                new Talent {Id = 77, TalentName = "Wyczucie kierunku", Description = "" },
                new Talent {Id = 78, TalentName = "Wykrywanie pułapek ", Description = "" },
                new Talent {Id = 79, TalentName = "Wyostrzone zmysły ", Description = "" },
                new Talent {Id = 80, TalentName = "Zapasy", Description = "" },
                new Talent {Id = 81, TalentName = "Zapiekła nienawiść ", Description = "" },
                new Talent {Id = 82, TalentName = "Zmysł magii", Description = "" },
                new Talent {Id = 83, TalentName = "Żyłka handlowa", Description = "" }
            };
        }
    }

    public enum TalentId
    {

    }
}
