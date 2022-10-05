//IMPORTANTE: Ricordatevi di sganciare la vostra vecchia repository GIT e di crearne una nuova per questo esercizio, che prosegue il lavoro della pizzeria, dove lo avevate lasciato.

//Ciao ragazzi, nuove implementazioni per la nostra applicazione.

//Abbiamo la lista delle pizze, abbiamo i dettagli delle pizze...perchè non creare la pagina per la creazione di una nuova pizza?
//Aggiungiamo quindi tutto il codice necessario per mostrare il form per la creazione di una nuova pizza e per il salvataggio dei dati nella lista che abbiamo in memoria.

//Nella index creiamo ovviamente il bottone “Crea nuova pizza” che ci porta a questa nuova pagina creata.
//Ricordiamoci che l’utente potrebbe sbagliare inserendo dei dati : gestiamo quindi la validazione!

//Ad esempio verifichiamo che :
//    i dati della pizza siano tutti presenti
//    il campi di testo non superino una certa lunghezza
//    il prezzo abbia un valore valido (ha senso una pizza con prezzo minore o uguale a zero?)

//Bonus Prevediamo una validazione in più : vogliamo che la descrizione della pizza contenga almeno 5 parole.

//ATTENZIONE: Stiamo lavorando con azioni che devono agire su un DB quindi, smettiamo di usare DB Fake e ricordiamoci di fare tutta la procedura per usare EntityFramework. Mi raccomando, create solo il modello della PIZZA e nient’altro.

//public List<Pizza> CreatePizza()
//{
//    List<Pizza> ListPizza = new List<Pizza> {

//        new Pizza("Pizza Margherita", "bona come er pane", "https://media-assets.vanityfair.it/photos/61e444841e21bc3bd54b5357/1:1/w_2832,h_2832,c_limit/pizza%20tendenze.jpg", 3.99),
//        new Pizza("Pizza Capricciosa", "idem co patate", "https://media-assets.vanityfair.it/photos/61e444841e21bc3bd54b5357/1:1/w_2832,h_2832,c_limit/pizza%20tendenze.jpg", 7.99),
//        new Pizza("Pizza Diavola", "er duca", "https://media-assets.vanityfair.it/photos/61e444841e21bc3bd54b5357/1:1/w_2832,h_2832,c_limit/pizza%20tendenze.jpg", 12.99),
//        new Pizza("Pizza Quattro Formaggi", "fiocina", "https://media-assets.vanityfair.it/photos/61e444841e21bc3bd54b5357/1:1/w_2832,h_2832,c_limit/pizza%20tendenze.jpg", 9.99),
//        new Pizza("Pizza Coi Funghi", "er monnezza", "https://media-assets.vanityfair.it/photos/61e444841e21bc3bd54b5357/1:1/w_2832,h_2832,c_limit/pizza%20tendenze.jpg", 11.99),
//        new Pizza("Pizza Salsiccia e Salame", "tonino u lurdu", "https://media-assets.vanityfair.it/photos/61e444841e21bc3bd54b5357/1:1/w_2832,h_2832,c_limit/pizza%20tendenze.jpg", 5.99),
//    };

//    return ListPizza;
//}