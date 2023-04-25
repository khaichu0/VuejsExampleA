<template>
  <section class="container">
    <div class="content">
      <navbar/>
      <label-content label="Chào mừng"/>
      <label-content label="Cảm ơn"/>
      <group-item-content/>
      <group-item-content/>

      <label-content label="Thêm thành phần"/>
    </div>
  </section>
</template>

<script>
import AppLogo from '~/components/AppLogo.vue'
import Navbar from '~/components/Navbar.vue'
import LabelContent from '~/components/LabelContent.vue'
import GroupItemContent from '~/components/GroupItemContent.vue'


export default {
  components: {
    AppLogo,
    Navbar,
    LabelContent,
    GroupItemContent
  }
}
</script>

<style>
.container{
position: relative;
/* width: 100%;
height: 100vh; */

/* grey / 02 */

background: #F4F4F4;
}
.content{
  /* Auto layout */

display: flex;
flex-direction: column;
align-items: flex-start;
padding: 0px 0px 48px 450px;
gap: 24px;

position: absolute;
left: 1px;
top: 120px;
}
</style>

