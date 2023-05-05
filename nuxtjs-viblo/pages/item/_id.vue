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

    <item-detail v-if="$route.params.group_item.type==1"  >
      <email-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></email-detail>
    </item-detail>
    <item-detail v-if="$route.params.group_item.type==2" >
      <phone-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></phone-detail>
    </item-detail>
    <item-detail v-if="$route.params.group_item.type==3" >
      <number-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></number-detail>
    </item-detail>
    <item-detail v-if="$route.params.group_item.type==4" >
      <float-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></float-detail>
    </item-detail>
    <item-detail v-if="$route.params.group_item.type==5" >
      <paragrap-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></paragrap-detail>
    </item-detail>
    <item-detail v-if="$route.params.group_item.type==6" >
      <calendar-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></calendar-detail>
    </item-detail>
    <item-detail v-if="$route.params.group_item.type==7" >
      <calendar-time-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></calendar-time-detail>
    </item-detail>
    <item-detail v-if="$route.params.group_item.type==8" >
      <credit-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></credit-detail>
    </item-detail>
    <item-detail v-if="$route.params.group_item.type==9" >
      <file-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></file-detail>
    </item-detail>
    <item-detail v-if="$route.params.group_item.type==10" >
      <select-option-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></select-option-detail>
    </item-detail>
    <item-detail v-if="$route.params.group_item.type==16" >
      <checkbox-grid-detail :item="$route.params.group_item" :group-index="$route.params.group_index"></checkbox-grid-detail>
    </item-detail>
  </div>
</template>
<script>
import ItemDetail from "~/components/item-component/ItemDetail.vue";
import FloatDetail from "~/components/item-component/float/FloatDetail.vue";
import NumberDetail from "~/components/item-component/number/NumberDetail.vue";
import EmailDetail from "~/components/item-component/email/EmailDetail.vue";
import PhoneDetail from "~/components/item-component/phone/PhoneDetail.vue";
import ParagrapDetail from "~/components/item-component/paragrap/ParagrapDetail.vue";
import CalendarDetail from "~/components/item-component/calendar/CalendarDetail.vue";
import CalendarTimeDetail from "~/components/item-component/calendar-time/CalendarTimeDetail.vue";
import CreditDetail from "~/components/item-component/credit/CreditDetail.vue";
import FileDetail from "~/components/item-component/file/FileDetail.vue";
import SelectOptionDetail from "~/components/item-component/select/SelectOptionDetail.vue";
import CheckboxGridDetail from "~/components/item-component/checkbox-grid/CheckboxGridDetail.vue";



export default{
  components: {
    EmailDetail,
    PhoneDetail,
    ItemDetail,
    NumberDetail,
    FloatDetail,
    ParagrapDetail,
    CalendarDetail,
    CalendarTimeDetail,
    CreditDetail,
    FileDetail,
    SelectOptionDetail,
    CheckboxGridDetail
  },

  methods: {
    goBack() {
      this.$router.go(-1);
    },
  },
};
</script>
