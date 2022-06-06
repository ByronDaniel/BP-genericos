using Genericos;
//String
ArrayGenerico<string> animales = new ArrayGenerico<string>(5);
animales.AgregarDato(1, "Perro");
animales.AgregarDato(2, "Gato");
Console.WriteLine(animales.VerDato(1));

//Double
ArrayGenerico<double> notas = new ArrayGenerico<double> (5);
notas.AgregarDato(1, 8.6);
notas.AgregarDato(2, 9.7);
Console.WriteLine(notas.VerDato(1));

//Usuario
ArrayGenerico<Usuario> usuarios = new ArrayGenerico<Usuario>(5);
usuarios.AgregarDato(1, new Usuario("54354545", "Daniela Martinez"));
usuarios.AgregarDato(2, new Usuario("11111111", "Andres Morales"));
Console.WriteLine(usuarios.VerDato(2).NombreCompleto);

