<template>
  <div class="checkbox">
    <label class="checkbox-status" for="">Bắt buộc</label>
    <label class="toggle" for="toggle">
      <input type="checkbox" id="toggle" />
      <div class="slider"></div>
    </label>
  </div>
</template>
<style scoped>
@import url('https://fonts.googleapis.com/css?family=Inter');

.toggle {
  display: inline-block;
  height: 20px;
  width: 53px;
}
.toggle input[type="checkbox"] {
  display: none;
}
.toggle .slider {
  background-color: #ccc;
  cursor: pointer;
  width: 100%;
  height: 100%;
  transition: 0.4s;
  position: relative;
  border-radius: 50px;
  top: 10px;
}
.toggle .slider:before {
  background-color: #fff;
  bottom: -2px;
  content: "";
  height: 26px;
  /* left: 4px; */
  position: absolute;
  transition: 0.4s;
  width: 26px;
  border-radius: 50px;
}
.toggle input[type="checkbox"]:checked + .slider {
  background-color: #07a787;
  top: 10px;
}
.toggle input[type="checkbox"]:checked + .slider:before {
  transform: translateX(30px);
}
.checkbox-status{
  margin: 0 10px;
  height: 22px;
  clear: both;
  display: inline-block;
  white-space: nowrap;
  font-weight: bold;
  font-family: "Inter";
  font-style: normal;
  font-weight: 600;
  font-size: 16px;
  line-height: 40px;
}
.checkbox{
  display: flex;
}
</style>
