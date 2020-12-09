-------------
CovidCounter
-------------

A szoftver egyetlen Formból áll, amin megtalálható az összes kellő információ a megfelelő használathoz.
A szoftver futtatása során betölti az XML-ből az adatokat egy Binding Listbe, melynek a későbbiekben nagyon fontos szerepe van. Az adatok betöltése után megjelenik a felhasználói felület, melyen látható:
	o két textBox és két datetimePicker szűrési célzattal,
	o Egy "Search"/"Reset"/"Random"/"Save Results" felíratú gomb,
	o Egy datagridview,
	o És egy chart.

TextBox: Ezekbe való gépeléssel, majd a "Search" gomb megnyomásával rászűr azokra az XML-ben található adatsorokra, melyek országának neve/kódja tartalmazza a felhasználó által begépelt karaktereket.

DatetimePicker: Ez is egy szűrési opció, mellyel beállíthatjuk, hogy mely két időpont közötti adatokra vagyunk kíváncsiak. Ezt beállítás után szintén a "Search" gomb megnyomásával lehet aktiválni, természetesen a textBox szűrőkkel együtt.

"Reset" gomb: Visszaállítja az alaphelyzetbe a programot.

"Random" gomb: Kilistázza egy az XML-ben szereplő, véletlenszerűen választott Ország adatsorait.

"Save Results" gomb: Lementi a felhasználó által beállított szűrök alapján a datagridviewban látott adatsorokat .csv formátumban.

Datagridview: Megjeleníti az összes adatsort, majd szűrés után a látni kívánt adatsorokat.(10-es esetszám alatt 0-át ad, míg 150 000 felett 150 000-et)

Chart: Megjeleníti az Esetszámok változását az idő elteltével.(X tengely=Dátum, Y tengely=Esetszám)

-------------
Készítette: Barkóczy Balázs (GUH8IJ)
