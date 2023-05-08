<template>
  <div>
    <!-- <header-content /> -->

    <nuxt/>
  </div>
</template>
<script>
import HeaderContent from "~/components/HeaderContent.vue";
export default{
  components: {
    HeaderContent,
  },
}

</script>
<style>
@import url("https://fonts.googleapis.com/css?family=Google+Sans");
html {
  font-family: "Google Sans";
  font-size: 16px;
  word-spacing: 1px;
  -ms-text-size-adjust: 100%;
  -webkit-text-size-adjust: 100%;
  -moz-osx-font-smoothing: grayscale;
  -webkit-font-smoothing: antialiased;
  box-sizing: border-box;
}

*, *:before, *:after {
  box-sizing: border-box;
  margin: 0;
}
</style>

