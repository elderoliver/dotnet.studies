// This is an  Enumerable list.
var listaDestinatarioEnvio = documentoInfo.list;  

// if you want to filter by email the same list 
listaDestinatarioEnvio = listaDestinatarioEnvio.Where(x => x.email == email); 
