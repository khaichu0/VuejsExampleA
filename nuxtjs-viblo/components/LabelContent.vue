<template>
  <div class="label_content_item">
    <span class="label_content">
      {{ label }}
    </span>
  </div>
</template>
<script>
export default {
  props: {
    label: String,
  },
};
</script>
<style scoped>
@import url('https://fonts.cdnfonts.com/css/google-sans');
.label_content_item {
  box-sizing: border-box;

  /* Auto layout */

  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  padding: 20px 10px;
  gap: 10px;

  width: 1055px;
  height: 60px;

  background: #ffffff;
  /* Blue / 06 */
  cursor: pointer;
  border: 1px solid #53b1fd;
  box-shadow: 0px 10px 20px rgba(0, 0, 0, 0.1);
  border-radius: 8px;

}
.label_content {
  font-family: "Product Sans";
  font-style: normal;
  font-weight: 700;
  font-size: 16px;
  line-height: 20px;

  /* Blue / 10 */

  color: #1849a9;
}
</style>
