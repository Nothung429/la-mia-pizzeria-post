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