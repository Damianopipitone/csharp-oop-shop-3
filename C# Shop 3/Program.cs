// See https://aka.ms/new-console-template for more information
// INIZIALIZZARE UNO SHOP 
// LISTA PRODOTTI
// SI POSSONO CHIEDERE OGNUNA DELLE INFORMAZIONI CONTENUTE NEL NEGOZIO
// SI POSSA MODIFICARE ALCUNE INFORMAZIONI
// SI POSSA INSERIRE LA LISTA DI PRODOTTI INIZIALI O NUOVI
// SI POSSA INSERIRE ANCHE UN PRODOTTO SINGOLO 
// LA RAPPRESENTAZIONE IN STRINGA E SI POSSA STAMPARLE IN CONSOLE


using CSharp_Composizione_Shop;

// DEFINISCO IL MIO SHOP

Shop negozio = new Shop("Di tutto e di più", "Palermo", "Via Roma", 89, "Alimentare");

// DEFINISCO I PRODOTTI CHE IL MIO SHOP TRATTA
itemShop insalata = new itemShop("Insalata");
itemShop pollo = new itemShop("Pollo");
Water acqua = new Water("Acqua", "Levissima");

// DEFINISCO LE CATEGOIRE PER I MIEI PRODOTTO
Category verdura = new Category("Verdura", "Insalata verde");
Category carne = new Category("Carne", "Pollo allevato a terra");
Category bevande = new Category("Bevande", "Bevande");

// ASSOCIO I PRODOTTI CON LE LORO CATEGORIE
insalata.addCaetogy(verdura);
pollo.addCaetogy(carne);
acqua.addCaetogy(bevande);

negozio.addItem(insalata);
negozio.addItem(pollo);
negozio.addItem(acqua);


Console.WriteLine(negozio.InfoShop());
acqua.SetRefill(1.5f);
acqua.Bevi(0.8f);

