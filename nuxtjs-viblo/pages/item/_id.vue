<template>
  <div>
    <h1>Item Page</h1>
    <!-- item content -->
    <button @click="goBack">Go Back</button>
    <nuxt-link to="/">About page</nuxt-link>
    <p>Param 1: {{ $route.params.id }}</p>
    <p>Param 2: {{ $route.params.group_id }}</p>
  </div>
</template>
<script>
export default {
  methods: {
    goBack() {
      this.$router.go(-1);
    },
  },
};
</script>
