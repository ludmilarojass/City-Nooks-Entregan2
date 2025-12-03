/*Utilities */
/* Fuente Nunito */
@import url("https://fonts.googleapis.com/css2?family=Nunito+Sans:wght@300;400;600;700&display=swap");
.ruleta-wrapper .col-invitar, .card {
  border: 2px solid #d88956;
  border-radius: 8px;
  padding: 16px;
}

/* Base */
/* Reset */
* {
  margin: 0%;
  padding: 0%;
}

body {
  background-color: pink;
  font-family: "Nunito Sans", sans-serif;
}

/*Components */
.cuerpo {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
  gap: 20px;
  padding: 40px;
}
.cuerpo img {
  max-width: 100%;
  height: auto;
  border-radius: 10px;
}
.cuerpo .boton {
  margin-top: 10px;
  padding: 12px 25px;
  background: #d97a50;
  color: white;
  border-radius: 8px;
  cursor: pointer;
  border: none;
  font-size: 16px;
  text-decoration: none;
  margin-top: 10px;
}

.navbar-brand img {
  width: 180px;
  height: auto;
}

.navbar {
  padding: 0.5rem 0;
}
.navbar .navbar-nav {
  gap: 30px;
  margin-left: auto;
  margin-right: auto;
}
.navbar .navbar-nav .nav-link {
  font-size: 18px;
  font-weight: 600;
  color: black;
  transition: 0.2s;
}
.navbar .navbar-nav .nav-link:hover {
  color: white;
  transform: scale(1.2);
}

/*Utilities */
/*Cards */
.card {
  width: 200px;
  text-align: center;
}
.card img {
  width: 100px;
  height: 180px;
  object-fit: cover;
  border-radius: 6px;
}
.card h4 {
  margin: 10px;
}

.conteiner {
  margin: 32px 0;
  display: flex;
  gap: 32px;
  justify-content: center;
  flex-wrap: wrap;
}

footer {
  background-color: #d88956;
  text-align: center;
  padding: 9px;
}

.p-footer {
  font-size: small;
  color: black;
}

.footer-redes {
  margin-top: 10px;
  display: flex;
  justify-content: center;
  gap: 12px;
}
.footer-redes img {
  width: 28px;
  height: 28px;
  cursor: pointer;
  transition: 0.2s;
}
.footer-redes img:hover {
  transform: scale(1.2);
}

.Formularios {
  display: flex;
  gap: 40px;
  padding: 40px;
  justify-content: center;
  align-items: flex-start;
}
.Formularios .img {
  width: 350px;
  border-radius: 10px;
}
.Formularios .form-container {
  max-width: 800px;
  width: 100%;
}
.Formularios .form-container .form-columns {
  display: flex;
  gap: 40px;
  margin-bottom: 20px;
}
.Formularios .form-container .form-columns .col {
  flex: 1;
}
.Formularios .form-container .form-columns .col input,
.Formularios .form-container .form-columns .col select {
  width: 100%;
  padding: 10px;
  margin-bottom: 14px;
  border-radius: 6px;
  border: 1px solid #aaa;
  background: #ffa266;
}
@media (max-width: 768px) {
  .Formularios {
    flex-direction: column;
    padding: 20px;
    align-items: center;
  }
  .Formularios .img {
    width: 200px;
    margin-bottom: 20px;
  }
  .Formularios .form-container {
    width: 100%;
  }
  .Formularios .form-container .form-columns {
    flex-direction: column;
    gap: 20px;
  }
}
@media (max-width: 480px) {
  .Formularios {
    padding: 15px;
  }
  .Formularios .img {
    width: 100%;
  }
  .Formularios .form-container .form-columns {
    gap: 15px;
  }
  .Formularios .form-container .col input,
  .Formularios .form-container .col select {
    padding: 8px;
  }
}

.boton {
  margin-top: 10px;
  padding: 12px 25px;
  background: #d97a50;
  color: white;
  border-radius: 8px;
  cursor: pointer;
  border: none;
  font-size: 16px;
  text-decoration: none;
}

header {
  background-color: #d88956;
  padding: 10px 20px;
}

/*Utilities */
.ruleta-wrapper {
  display: grid;
  grid-template-columns: 1fr 1fr;
  gap: 40px;
  align-items: center;
  max-width: 900px;
  margin: 40px auto;
}
.ruleta-wrapper .col-ruleta {
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
}
.ruleta-wrapper .col-ruleta .ruleta-img {
  width: 300px;
  margin-bottom: 20px;
}
.ruleta-wrapper .col-invitar {
  background-color: #d88956;
  text-align: center;
}
.ruleta-wrapper .col-invitar p {
  text-decoration: underline;
  color: blue;
}
.ruleta-wrapper .col-invitar .invitar-redes {
  display: flex;
  justify-content: flex-end;
  gap: 10px;
}
.ruleta-wrapper .col-invitar .invitar-redes img {
  width: 45px;
  height: 45px;
}
.ruleta-wrapper .col-invitar .invitar-redes img:hover {
  transform: scale(1.15);
}

/* Responsive */
@media (max-width: 768px) {
  .ruleta-wrapper {
    grid-template-columns: 1fr;
  }
}
/* Responsive */
@media (max-width: 768px) {
  .ruleta-wrapper {
    grid-template-columns: 1fr;
  }
}

/*# sourceMappingURL=main.cs.map */
