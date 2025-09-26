# 📘 Progreso — тренажёр когнитивных навыков

[![Windows](https://img.shields.io/badge/Platform-Windows-blue?logo=windows)](https://www.microsoft.com/windows)
[![C\#](https://img.shields.io/badge/Language-C%23-239120?logo=c-sharp)](https://docs.microsoft.com/dotnet/csharp/)
[![WinForms](https://img.shields.io/badge/UI-WinForms-0078D7)](https://docs.microsoft.com/dotnet/desktop/winforms/)
[![.NET Framework 4.6.1](https://img.shields.io/badge/.NET-4.6.1-brightgreen)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Status](https://img.shields.io/badge/status-active-brightgreen)](#)

---

> **Progreso** — настольное Windows-приложение (WinForms), набор мини-игр и упражнений на внимание, память и реакцию. Проект ориентирован на офлайн-использование: мультимедиа, локальные настройки и одиночный пользовательский опыт.

---

## 🔎 Что в репозитории
- `Progreso.exe` — собранная версия (release build) для Windows.
- `bin/` — множество артефактов сборки, `.obj`, `.pdb`, `.resx` и т.д.
- Исходники форм и логики приложения находятся в `bin/*.cs` (в архиве они положены в `bin/` — рекомендую поместить их в привычную структуру `src/` или в корень проекта при переносе в git).
- Ресурсы: `bin/Properties/Resources.resx` — картинки, звуки и шрифты включены как встроенные ресурсы.

---

## 🧭 Быстрый старт
1. Скачайте `Progreso.exe` (из раздела Releases или из корня репозитория).
2. Запустите двойным кликом на Windows (требуется .NET Framework 4.6.1 или выше).
3. Если Windows запросит разрешение — подтвердите. Приложение работает локально (нет сетевых запросов).

---

## 🛠️ Установка и сборка из исходников

### Требования (пререквизиты)
- Windows 10/11 (или старше, где поддерживается .NET Framework 4.6.1).
- Visual Studio 2017 / 2019 / 2022 (рекомендуется) с компонентом **“.NET desktop development”** и установленным **.NET Framework 4.6.1 Developer Pack**.
- (альтернатива) MSBuild (Visual Studio Build Tools) для сборки из командной строки.


### Сборка в Visual Studio
1. Откройте Visual Studio → `File` → `Open` → `Project/Solution`.
2. Выберите `Progreso-Yeah/bin/WindowsFormsApp1.csproj`.
3. Убедитесь, что целевой фреймворк — **.NET Framework 4.6.1**.
4. Build → `Build Solution` (или `Ctrl+Shift+B`).
5. Запустите (Debug/Release) `Progreso.exe` через Visual Studio или из папки `bin/Release`.

### Сборка через командную строку (MSBuild)
```bash
# Откройте Developer Command Prompt for Visual Studio
cd path\to\Progreso-Yeah\bin
msbuild WindowsFormsApp1.csproj /p:Configuration=Release
# результат в bin\Release\Progreso.exe (или там, где указан OutputPath)
