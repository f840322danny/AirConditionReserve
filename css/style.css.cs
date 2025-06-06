/* ===== 全頁共用樣式 ===== */
* {
  box-sizing: border-box;
}
body {
  margin: 0;
  padding: 0;
  font-family: "微軟正黑體", sans-serif;
  background-color: #f5f5f5;
  color: #333;
}
a {
  text-decoration: none;
  color: inherit;
}
ul {
  list-style: none;
  margin: 0;
  padding: 0;
}

/* ===== 頁首 Navbar ===== */
header {
  position: relative;
  width: 100%;
  background-color: #0070f3;
  color: #fff;
  z-index: 1000;
  /* 如果要固定在頂部，取消下一行註解 */
  /* position: fixed; top: 0; */
}
.navbar {
  max-width: 1200px;
  margin: 0 auto;
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 10px 20px;
}
/* 左側網站 Logo / 名稱 */
.navbar .logo {
  font-size: 24px;
  font-weight: bold;
  letter-spacing: 1px;
}
/* 右側選單容器 */
.navbar nav {
  display: flex;
  align-items: center;
}
.navbar nav > ul {
  display: flex;
  align-items: center;
}
.navbar nav > ul > li {
  position: relative;
  margin-left: 24px;
}
.navbar nav ul li a {
  color: #fff;
  padding: 8px 12px;
  display: block;
  font-size: 16px;
}
.navbar nav ul li a:hover {
  background-color: rgba(255, 255, 255, 0.2);
  border-radius: 4px;
}

/* 下拉選單樣式 */
.navbar nav ul li .dropdown {
  display: none;
  position: absolute;
  top: 100%;
  left: 0;
  background-color: rgba(0, 112, 243, 0.95);
  border-radius: 4px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.15);
  min-width: 160px;
}
.navbar nav ul li:hover .dropdown {
  display: block;
}
.navbar nav ul li .dropdown li {
  margin: 0;
}
.navbar nav ul li .dropdown li a {
  padding: 8px 12px;
  color: #fff;
  font-size: 14px;
}
.navbar nav ul li .dropdown li a:hover {
  background-color: rgba(255, 255, 255, 0.2);
}

/* ===== Banner 圖片 ===== */
.banner {
  width: 100%;
  /* 如果 header 固定，請考慮為 banner 或 body 加上 top-padding，以免遮到內容 */
}
.banner img {
  width: 100%;
  height: auto;
  display: block;
}

/* ===== 表單區塊 ===== */
.form-container {
  max-width: 600px;
  margin: 40px auto 80px;
  padding: 20px;
  background-color: #fff;
  border-radius: 8px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.1);
}
.form-container h2 {
  margin-bottom: 20px;
  text-align: center;
  color: #0070f3;
}
.form-group {
  margin-bottom: 16px;
}
.form-group label {
  display: block;
  margin-bottom: 6px;
  font-weight: bold;
}
.form-group input[type="text"],
.form-group input[type="email"],
.form-group input[type="tel"],
.form-group input[type="datetime-local"],
.form-group textarea,
.form-group select {
  width: 100%;
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 4px;
  font-size: 14px;
  box-sizing: border-box;
}
.form-group textarea {
  resize: vertical;
  min-height: 80px;
}
.btn-submit {
  display: block;
  width: 100%;
  padding: 12px;
  background-color: #0070f3;
  color: #fff;
  font-size: 16px;
  font-weight: bold;
  text-align: center;
  border: none;
  border-radius: 4px;
  cursor: pointer;
  margin-top: 10px;
}
.btn-submit:hover {
  background-color: #005bb5;
}
.note {
  font-size: 12px;
  color: #666;
  margin-top: 8px;
  text-align: right;
}

/* ===== 響應式調整 ===== */
@media (max-width: 768px) {
  .navbar .logo {
    font-size: 20px;
  }
  .navbar nav ul li {
    margin-left: 12px;
  }
}
/* 手機版 (max-width: 480px) */
@media (max-width: 480px) {
  .form-container {
    margin: 20px 10px 40px;
    padding: 16px;
  }
  /* 手機版：隱藏一般 nav，並由 .menu-toggle 來控制顯示 */
  .navbar nav {
    display: none;
    flex-direction: column;
    background-color: #0070f3;
    position: absolute;
    top: 100%;
    left: 0;
    right: 0;
  }
  .navbar nav.open {
    display: flex;
  }
  .navbar .menu-toggle {
    display: block;
    font-size: 24px;
    cursor: pointer;
  }
  .navbar nav ul {
    flex-direction: column;
  }
  .navbar nav ul li {
    margin: 0;
  }
}
