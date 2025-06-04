# weather_viewer.py

def get_weather(city):
    # Імітація отримання погоди
    fake_weather_data = {
        "Київ": "Сонячно, +25°C",
        "Львів": "Дощ, +18°C",
        "Одеса": "Хмарно, +22°C"
    }
    return fake_weather_data.get(city, "Погода для цього міста недоступна.")

def main():
    print("=== Перегляд погоди ===")
    city = input("Введіть назву міста: ")
    weather = get_weather(city)
    print(f"Погода у місті {city}: {weather}")

if __name__ == "__main__":
    main()
