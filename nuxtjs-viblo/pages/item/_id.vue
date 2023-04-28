<template>
  <div class="item-block">
    <!--
    <button @click="goBack">Go Back</button>
    <nuxt-link to="/">About page</nuxt-link>
    <p>Param 1: {{ $route.params.id }}</p>
    <p>Param 2: {{ $route.params.group_id }}</p> -->
    <!-- v-show="$route.query.item.type==1" -->
    <!-- <p>{{$route.params.group_item}}</p> -->
    <!-- v-show="$route.query.item.type==1" -->

    <item-detail v-show="$route.params.group_item.type==1"  >
      <email-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></email-detail>
    </item-detail>
    <item-detail v-show="$route.params.group_item.type==2" >
      <phone-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></phone-detail>
    </item-detail>
    <item-detail v-show="$route.params.group_item.type==3" >
      <number-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></number-detail>
    </item-detail>
    <item-detail v-show="$route.params.group_item.type==4" >
      <float-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></float-detail>
    </item-detail>

  </div>
</template>
<script>
import ItemDetail from "~/components/item-component/ItemDetail.vue";
import FloatDetail from "~/components/item-component/float/FloatDetail.vue";
import NumberDetail from "~/components/item-component/number/NumberDetail.vue";
import EmailDetail from "~/components/item-component/email/EmailDetail.vue";
import PhoneDetail from "~/components/item-component/phone/PhoneDetail.vue";

export default {
  components: {
    EmailDetail,
    PhoneDetail,
    ItemDetail,
    NumberDetail,
    FloatDetail
  },

  methods: {
    goBack() {
      this.$router.go(-1);
    },
  },
};
</script>
