import mysql.connector 

def connect_to_database():
    try:
        connection = mysql.connector.connect(
            host="localhost",  # Ndryshoni sipas konfigurimit tuaj
            user="root",       # Vendosni emrin e përdoruesit
            password="your_password",  # Vendosni fjalëkalimin tuaj
            database="your_database"   # Vendosni emrin e databazës suaj
        )
        print("Lidhja me bazën e të dhënave u krye me sukses!")
        return connection
    except mysql.connector.Error as e:
        print(f"Gabim gjatë lidhjes: {e}")
        return None

def insert_record(connection, table, data):
    cursor = connection.cursor()
    query = f"INSERT INTO {table} (column1, column2, ...) VALUES (%s, %s, ...)"
    values = tuple(data)
    try:
        cursor.execute(query, values)
        connection.commit()
        print(f"Regjistri u shtua me sukses në tabelën {table}.")
    except mysql.connector.Error as e:
        print(f"Gabim gjatë shtimit të regjistrit: {e}")
    finally:
        cursor.close()
