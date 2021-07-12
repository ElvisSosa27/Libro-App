using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibroAppDB.Models;
using Microsoft.EntityFrameworkCore;

namespace LibroApp
{
    public class CRUDClass
    {
        public void AddAuthors()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            Console.Write("Diga el nombre del autor que desea agregar: ");
            string name = Convert.ToString(Console.ReadLine());

            Console.Write("Diga el correo del autor que desea agregar: ");
            string email = Convert.ToString(Console.ReadLine());

            var author = new Author()
            {
                Name = name,
                Email = email
            };

            db.Authors.Add(author);
            db.SaveChanges();

            Console.WriteLine("Autor agregado satisfactoriamente.");
            Console.ReadKey();
            Console.Clear();
        }

        public void EditAuthors()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            var listAuthors = db.Authors.OrderBy(x => x.Name);

            Task task = new Task(() => TaskListAuthors());
            task.Start();

            Console.WriteLine("Seleccione el autor que desea editar: ");
            int idAuthor = int.Parse(Console.ReadLine());

            var editAuthors = db.Authors.FirstOrDefault<Author>(x => x.Id == idAuthor);

            Console.Clear();
            Console.Write("Escriba el nuevo nombre del autor: ");
            string name = Convert.ToString(Console.ReadLine());

            Console.Write("Escriba el nuevo correo del autor: ");
            string email = Convert.ToString(Console.ReadLine());

            editAuthors.Name = name;
            editAuthors.Email = email;
            
            db.SaveChanges();

            Console.WriteLine("Autor editado satisfactoriamente.");
            Console.ReadKey();
            Console.Clear();
        }

        public void DeleteAuthors()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            Task task = new Task(() => TaskListAuthors());
            task.Start();

            Console.WriteLine("Seleccione el autor que desea eliminar: ");
            int idAuthor = int.Parse(Console.ReadLine());

            var deleteAuthor = db.Authors.FirstOrDefault<Author>(x => x.Id == idAuthor);
            db.Authors.Remove(deleteAuthor);

            Console.Write("¿Seguro que desea eliminar el autor seleccionado?(S/N)");

            if(Console.ReadKey(true).KeyChar == 's')
            {
                db.SaveChanges();
                Console.WriteLine("\nAutor eliminado satisfactoriamente");
                Console.ReadKey();
                Console.Clear();
            }
            else if(Console.ReadKey(true).KeyChar == 'n')
            {
                Console.WriteLine("\nProceso cancelado");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void ListAuthors()
        {
            Task task = new Task(() => TaskListAuthors());
            task.Start();
            Console.ReadKey();
            Console.Clear();
        }

        public void AddCategories()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            Console.Write("Diga el nombre de la categoría que desea agregar: ");
            string name = Convert.ToString(Console.ReadLine());

            var category = new Category()
            {
                Name = name
            };

            db.Categories.Add(category);
            db.SaveChanges();

            Console.WriteLine("Categoría agregada satisfactoriamente.");
            Console.ReadKey();
            Console.Clear();
        }

        public void EditCategories()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            Task task = new Task(() => TaskListCategories());
            task.Start();

            Console.WriteLine("Seleccione la categoría que desea editar: ");
            int idCategory = int.Parse(Console.ReadLine());

            var editCategories = db.Categories.FirstOrDefault<Category>(x => x.Id == idCategory);

            Console.Clear();
            Console.Write("Escriba el nuevo nombre de la categoría: ");
            string name = Convert.ToString(Console.ReadLine());

            editCategories.Name = name;

            db.SaveChanges();

            Console.WriteLine("Categoría editada satisfactoriamente.");
            Console.ReadKey();
            Console.Clear();
        }

        public void DeleteCategories()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            Task task = new Task(() => TaskListCategories());
            task.Start();

            Console.WriteLine("Seleccione la categoría que desea eliminar: ");
            int idCategory = int.Parse(Console.ReadLine());

            var deleteCategory = db.Categories.FirstOrDefault<Category>(x => x.Id == idCategory);
            db.Categories.Remove(deleteCategory);

            Console.Write("¿Seguro que desea eliminar la categoría seleccionada?(S/N)");

            if (Console.ReadKey(true).KeyChar == 's')
            {
                db.SaveChanges();
                Console.WriteLine("\nCategoría eliminada satisfactoriamente");
                Console.ReadKey();
                Console.Clear();
            }
            else if (Console.ReadKey(true).KeyChar == 'n')
            {
                Console.WriteLine("\nProceso cancelado");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void ListCategories()
        {
            Task task = new Task(() => TaskListCategories());
            task.Start();
            Console.ReadKey();
            Console.Clear();
        }

        public void AddPublishers()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            Console.Write("Diga el nombre del editorial que desea agregar: ");
            string name = Convert.ToString(Console.ReadLine());

            Console.Write("Diga el teléfono de la editorial que desea agregar: ");
            string phone = Convert.ToString(Console.ReadLine());

            Console.Write("Diga el nombre del país al que pertenece el editorial que desea agregar: ");
            string country = Convert.ToString(Console.ReadLine());

            var publisher = new Publisher()
            {
                Name = name,
                Phone = phone,
                Country = country
            };

            db.Publishers.Add(publisher);
            db.SaveChanges();

            Console.WriteLine("Editorial agregado satisfactoriamente.");
            Console.ReadKey();
            Console.Clear();
        }

        public void EditPublishers()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            Task task = new Task(() => TaskListPublishers());
            task.Start();

            Console.WriteLine("Seleccione el editorial que desea editar: ");
            int idPublisher = int.Parse(Console.ReadLine());

            var editPublishers = db.Publishers.FirstOrDefault<Publisher>(x => x.Id == idPublisher);

            Console.Clear();
            Console.Write("Escriba el nuevo nombre del editorial: ");
            string name = Convert.ToString(Console.ReadLine());

            Console.Write("Escriba el nuevo teléfono del editorial: ");
            string phone = Convert.ToString(Console.ReadLine());

            Console.Write("Escriba el nuevo país de origen del editorial: ");
            string country = Convert.ToString(Console.ReadLine());

            editPublishers.Name = name;
            editPublishers.Phone = phone;
            editPublishers.Country = country;

            db.SaveChanges();

            Console.WriteLine("Editorial editado satisfactoriamente.");
            Console.ReadKey();
            Console.Clear();
        }

        public void DeletePublishers()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            Task task = new Task(() => TaskListPublishers());
            task.Start();

            Console.WriteLine("Seleccione el editorial que desea eliminar: ");
            int idPublisher = int.Parse(Console.ReadLine());

            var deletePublisher = db.Publishers.FirstOrDefault<Publisher>(x => x.Id == idPublisher);
            db.Publishers.Remove(deletePublisher);

            Console.Write("¿Seguro que desea eliminar el editorial seleccionado?(S/N)");

            if (Console.ReadKey(true).KeyChar == 's')
            {
                db.SaveChanges();
                Console.WriteLine("\nEditorial eliminado satisfactoriamente");
                Console.ReadKey();
                Console.Clear();
            }
            else if (Console.ReadKey(true).KeyChar == 'n')
            {
                Console.WriteLine("\nProceso cancelado");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void ListPublishers()
        {
            Task task = new Task(() => TaskListPublishers());
            task.Start();
            Console.ReadKey();
            Console.Clear();
        }

        public void AddBooks()
        {
            Category cat = new Category();
            Author aut = new Author();
            Publisher pub = new Publisher();

            if (cat.Name == " " || aut.Name == " " || pub.Name == " ")
            {
                Console.WriteLine("Hay datos que están vacíos dentro de la base de datos, por lo tanto no es posible continuar con este proceso.");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                LibroAppDBContext db = new LibroAppDBContext();

                Console.Write("Diga el nombre del libro que desea agregar: ");
                string name = Convert.ToString(Console.ReadLine());

                Console.Write("Diga el año del libro que desea agregar: ");
                int year = int.Parse(Console.ReadLine());

                Console.Clear();
                var listCategories = db.Categories.ToList();

                Parallel.ForEach(listCategories, category =>
                {
                    Console.WriteLine($"\nID de la categoría: {category.Id}\n" + $"\nNombre de la categoría: {category.Name}\n");
                });

                Console.Write("Diga el nombre de la categoría que esté disponible: ");
                string category = Convert.ToString(Console.ReadLine());

                Console.Clear();
                var listAuthors = db.Authors.ToList();

                Parallel.ForEach(listAuthors, author =>
                {
                    Console.WriteLine($"\nID del autor: {author.Id}\n" + $"\nNombre del autor: {author.Name}\n" + $"\nCorreo del autor: {author.Email}\n");
                });

                Console.Write("Diga el nombre de la categoría que esté disponible: ");
                string author = Convert.ToString(Console.ReadLine());

                Console.Clear();
                var listPublishers = db.Publishers.ToList();

                Parallel.ForEach(listPublishers, publisher =>
                {
                    Console.WriteLine($"\nID del editorial: {publisher.Id}\n" + $"\nNombre del editorial: {publisher.Name}\n" + $"\nTeléfono del editorial: {publisher.Phone}\n" + $"\nPaís de origen del editorial: {publisher.Country}\n");
                });
                Console.Write("Diga el nombre del editorial que esté disponible: ");
                string publisher = Convert.ToString(Console.ReadLine());

                var book = new Book()
                {
                    Name = name,
                    Year = year,
                    Category = category,
                    Author = author,
                    Publisher = publisher
                };

                db.Books.Add(book);
                db.SaveChanges();

                Console.WriteLine("Libro agregado satisfactoriamente.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void EditBooks()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            var listBooks = db.Books.OrderBy(x => x.Name);

            Parallel.ForEach(listBooks, book =>
            {
                Console.WriteLine($"\nID del libro: {book.Id}\n" + $"\nNombre del libro: {book.Name}\n" + $"\nAño de publicación del libro: {book.Year}\n" + $"\nCategoría del libro: {book.Category}\n" + $"\nAutor del libro: {book.Author}\n" + $"\nEditorial del libro: {book.Publisher}\n");
            });
            Console.WriteLine("Seleccione el libro que desea editar: ");
            int idBook = int.Parse(Console.ReadLine());

            var editBooks = db.Books.FirstOrDefault<Book>(x => x.Id == idBook);

            Console.Clear();
            Console.Write("Escriba el nuevo nombre del libro: ");
            string name = Convert.ToString(Console.ReadLine());

            Console.Write("Escriba el nuevo año del libro: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Escriba la nueva categoría del libro: ");
            string category = Convert.ToString(Console.ReadLine());

            Console.Write("Escriba el nuevo autor del libro: ");
            string author = Convert.ToString(Console.ReadLine());

            Console.Write("Escriba el nuevo editorial del libro: ");
            string publisher = Convert.ToString(Console.ReadLine());

            editBooks.Name = name;
            editBooks.Year = year;
            editBooks.Category = category;
            editBooks.Author = author;
            editBooks.Publisher = publisher;

            db.SaveChanges();

            Console.WriteLine("Libro editado satisfactoriamente.");
            Console.ReadKey();
        }

        public void DeleteBooks()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            Task task = new Task(() => TaskListBooks());
            task.Start();

            Console.WriteLine("Seleccione el libro que desea eliminar: ");
            int idBook = int.Parse(Console.ReadLine());

            var deleteBook = db.Books.FirstOrDefault<Book>(x => x.Id == idBook);
            db.Books.Remove(deleteBook);

            Console.Write("¿Seguro que desea eliminar el libro seleccionado?(S/N)");

            if (Console.ReadKey(true).KeyChar == 's')
            {
                db.SaveChanges();
                Console.WriteLine("\nLibro eliminado satisfactoriamente");
                Console.ReadKey();
                Console.Clear();
            }
            else if (Console.ReadKey(true).KeyChar == 'n')
            {
                Console.WriteLine("\nProceso cancelado");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void ListBooks()
        {
            Task task = new Task(() => TaskListBooks());
            task.Start();
            Console.ReadKey();
            Console.Clear();
        }

        public void SearchBookByName()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            var sortOrderByName = db.Books.OrderBy(x => x.Name);

            Parallel.ForEach(sortOrderByName, book =>
            {
                Console.WriteLine($"\nID del libro: {book.Id}\n" + $"\nNombre del libro: {book.Name}\n" + $"\nAño de publicación del libro: {book.Year}\n" + $"\nCategoría del libro: {book.Category}\n" + $"\nAutor del libro: {book.Author}\n" + $"\nEditorial del libro: {book.Publisher}\n");
            });
            Console.ReadKey();
            Console.Clear();
        }

        public void SearchBookByCategory()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            var sortOrderByCategory = db.Books.OrderBy(x => x.Category);

            Parallel.ForEach(sortOrderByCategory, book =>
            {
                Console.WriteLine($"\nID del libro: {book.Id}\n" + $"\nNombre del libro: {book.Name}\n" + $"\nAño de publicación del libro: {book.Year}\n" + $"\nCategoría del libro: {book.Category}\n" + $"\nAutor del libro: {book.Author}\n" + $"\nEditorial del libro: {book.Publisher}\n");
            });
            Console.ReadKey();
            Console.Clear();
        }

        public void SearchBookByYear()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            var sortOrderByYear = db.Books.OrderBy(x => x.Year);

            Parallel.ForEach(sortOrderByYear, book =>
            {
                Console.WriteLine($"\nID del libro: {book.Id}\n" + $"\nNombre del libro: {book.Name}\n" + $"\nAño de publicación del libro: {book.Year}\n" + $"\nCategoría del libro: {book.Category}\n" + $"\nAutor del libro: {book.Author}\n" + $"\nEditorial del libro: {book.Publisher}\n");
            });
            Console.ReadKey();
            Console.Clear();
        }

        public void SearchBookByAuthor()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            var sortOrderByAuthor = db.Books.OrderBy(x => x.Author);

            Parallel.ForEach(sortOrderByAuthor, book =>
            {
                Console.WriteLine($"\nID del libro: {book.Id}\n" + $"\nNombre del libro: {book.Name}\n" + $"\nAño de publicación del libro: {book.Year}\n" + $"\nCategoría del libro: {book.Category}\n" + $"\nAutor del libro: {book.Author}\n" + $"\nEditorial del libro: {book.Publisher}\n");
            });
            Console.ReadKey();
            Console.Clear();
        }

        public void SearchBookByPublisher()
        {
            Console.Clear();
            LibroAppDBContext db = new LibroAppDBContext();

            var sortOrderByPublisher = db.Books.OrderBy(x => x.Publisher);

            Parallel.ForEach(sortOrderByPublisher, book =>
            {
                Console.WriteLine($"\nID del libro: {book.Id}\n" + $"\nNombre del libro: {book.Name}\n" + $"\nAño de publicación del libro: {book.Year}\n" + $"\nCategoría del libro: {book.Category}\n" + $"\nAutor del libro: {book.Author}\n" + $"\nEditorial del libro: {book.Publisher}\n");
            });
            Console.ReadKey();
            Console.Clear();
        }

        private void TaskListAuthors()
        {
            LibroAppDBContext db = new LibroAppDBContext();

            var listAuthors = db.Authors.OrderBy(x => x.Name);

            Parallel.ForEach(listAuthors, author =>
            {
                Console.WriteLine($"\nID del autor: {author.Id}\n" + $"\nNombre del autor: {author.Name}\n" + $"\nCorreo del autor: {author.Email}\n");
            });
        }

        private void TaskListCategories()
        {
            LibroAppDBContext db = new LibroAppDBContext();

            var listCategories = db.Categories.OrderBy(x => x.Name);

            Parallel.ForEach(listCategories, category =>
            {
                Console.WriteLine($"\nID de la categoría: {category.Id}\n" + $"\nNombre de la categoría: {category.Name}\n");
            });
        }

        private void TaskListPublishers()
        {
            LibroAppDBContext db = new LibroAppDBContext();

            var listPublishers = db.Publishers.OrderBy(x => x.Name);

            Parallel.ForEach(listPublishers, publisher =>
            {
                Console.WriteLine($"\nID del editorial: {publisher.Id}\n" + $"\nNombre del editorial: {publisher.Name}\n" + $"\nTeléfono del editorial: {publisher.Phone}\n" + $"\nPaís de origen del editorial: {publisher.Country}\n");
            });
        }

        private void TaskListBooks()
        {
            LibroAppDBContext db = new LibroAppDBContext();

            var listBooks = db.Books.OrderBy(x => x.Name);

            Parallel.ForEach(listBooks, book =>
            {
                Console.WriteLine($"\nID del libro: {book.Id}\n" + $"\nNombre del libro: {book.Name}\n" + $"\nAño de publicación del libro: {book.Year}\n" + $"\nCategoría del libro: {book.Category}\n" + $"\nAutor del libro: {book.Author}\n" + $"\nEditorial del libro: {book.Publisher}\n");
            });
        }
    }
}
