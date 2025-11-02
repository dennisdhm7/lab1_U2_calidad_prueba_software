# 📘 Laboratorio U2 - Pruebas Unitarias con MSTest

**Curso:** Calidad y Pruebas de Software  
**Alumno:** Christian Dennis Hinojosa Mucho  
**Código:** SI784  
**Periodo:** 2025-II  

---

## 🧩 Descripción
Este laboratorio implementa una librería matemática `Math.Lib` con pruebas unitarias usando **MSTest** y cobertura de código.  
Además, se documenta automáticamente con **DocFX** y se publica en **GitHub Pages** mediante un flujo de trabajo continuo.

---

## 📚 Estructura del proyecto
- `Math.Lib` → Librería principal (clase `Rooter`)
- `Math.Tests` → Proyecto de pruebas unitarias
- `Cobertura` → Reporte de cobertura HTML
- `docs` → Documentación adicional generada por DocFX

---

## 🔧 Generación de documentación
```bash
docfx docfx.json
docfx serve _site
```
## 📊 Reporte de Cobertura

Visualiza el reporte de cobertura de código generado automáticamente:

👉 [🔍 Ver reporte de cobertura](coverage/index.html)

<p align="center">
  <a href="coverage/index.html" target="_blank" style="text-decoration:none;">
    <img src="https://img.shields.io/badge/Coverage-100%25-brightgreen?style=for-the-badge&logo=github" alt="Cobertura">
  </a>
</p>