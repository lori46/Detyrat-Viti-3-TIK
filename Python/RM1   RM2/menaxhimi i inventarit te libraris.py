def library_menu():
    inventory = []
    while True:
        print("\nMenuja Interaktive:")
        print("1. Regjistrimi i Librave")
        print("2. Shfaqja e Librave")
        print("3. Kërkimi i Librave")
        print("4. Dalje nga Programi")

        choice = input("Zgjidhni një opsion: ")

        if choice == "1":
            register_book(inventory)
        elif choice == "2":
            display_books(inventory)
        elif choice == "3":
            search_books(inventory)
        elif choice == "4":
            print("Duke dalë nga programi...")
            break
        else:
            print("Opsion i pavlefshëm. Ju lutemi provoni përsëri.")

def register_book(inventory):
    title = input("Vendos titullin e librit: ")
    author = input("Vendos autorin e librit: ")
    year = input("Vendos vitin e publikimit: ")
    try:
        copies = int(input("Vendos numrin e kopjeve: "))
    except ValueError:
        print("Numri i kopjeve duhet të jetë një numër. Regjistrimi dështoi.")
        return
    book = {"title": title, "author": author, "year": year, "copies": copies}
    inventory.append(book)
    print(f"Libri '{title}' u regjistrua me sukses.")

def display_books(inventory):
    print("\nLibrat në Inventar:")
    for book in inventory:
        if book["copies"] == 0:
            continue
        print(f"Titulli: {book['title']}, Autori: {book['author']}, Viti: {book['year']}, Kopje: {book['copies']}")

def search_books(inventory):
    search_choice = input("\nKërkoni sipas (1. Titulli, 2. Autori): ")
    query = input("Vendosni tekstin e kërkimit: ")
    found = False
    for book in inventory:
        if search_choice == "1" and query.lower() in book["title"].lower():
            found = True
            print(f"U gjet: Titulli: {book['title']}, Autori: {book['author']}, Viti: {book['year']}, Kopje: {book['copies']}")
        elif search_choice == "2" and query.lower() in book["author"].lower():
            found = True
            print(f"U gjet: Titulli: {book['title']}, Autori: {book['author']}, Viti: {book['year']}, Kopje: {book['copies']}")
    if not found:
        print("Nuk u gjet asnjë libër që përputhet me kërkimin.")

# Ekzekutimi i programit
if __name__ == "__main__":
    library_menu()
