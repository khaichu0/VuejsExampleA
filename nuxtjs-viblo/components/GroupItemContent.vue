<template>
  <div>
    <navbar @add-item="addItem" ref="child" />
    <div class="group_item_content_item">
      <div class="header_group_content">
        <div class="item_content_header_title">
          <label v-if="!editing" @click="startEditing">{{ labelText }}</label>

          <!-- <input-custom v-show="editing" type="text" @blur="stopEditing" /> -->
        </div>
        <div class="item_content_header_function">
          <checkbox :groupIndex="groupIndex" />
          <item-content-function :key="groupIndex" />
        </div>
      </div>
      <div class="body_group_content">
        <item-content
          v-for="(item, index) in items"
          :key="index"
          :item="item"
          @navigate-to-item="onItemClicked"
        />
      </div>
    </div>
  </div>
</template>
<script>
import ItemContentFunction from "~/components/ItemContentFunction.vue";
import Navbar from "~/components/Navbar.vue";
import Checkbox from "~/components/Checkbox.vue";
import ItemContent from "~/components/ItemContent.vue";
// import InputCustom from "~/components/InputCustom.vue";
import { stringify } from "querystring";
export default {
  components: {
    ItemContent,
    ItemContentFunction,
    Checkbox,
    // InputCustom,
    Navbar,
  },
  props: {
    items: Array,
    groupIndex: {
      type: Number,
      required: true,
    },
    groupId:String,
    activeGroupIndex:{
      type:Number,
    }
  },
  data() {
    return {
      groupNumber: 1,
      labelText: "Text something here",
      editing: false,
      inputValue: "",
      listItem: [],
      activeGroup: null,
      groupSelectedId:this.groupId
    };
  },
  methods: {
    startEditing() {
      this.editing = true;
    },
    stopEditing() {
      this.editing = false;
    },
    addItem(newItem) {
      this.$emit("add-item",newItem);
    },
    isActive(index) {
      return this.activeGroup === null || this.activeGroup === index;
    },
    selectGroup(index) {
      this.$emit('selectGroup', index);
    },
    onItemClicked(item) {
      this.$router.push({ name: "item-id", params: { id: item.id ,group_item:item,group_index:this.groupIndex} });
    },
  },
  watch: {
    value(newValue) {
      this.inputValue = newValue;
      console.log(
        "🚀 ~ file: GroupItemContent.vue:72 ~ value ~ newValue:",
        newValue
      );
      console.log(
        "🚀 ~ file: GroupItemContent.vue:72 ~ value ~ inputValue:",
        inputValue
      );
    },
    inputValue(newValue) {
      this.$emit("input", newValue);
      console.log(
        "🚀 ~ file: GroupItemContent.vue:72 ~ value ~ inputValue:",
        inputValue
      );
    },
    activeGroupIndex(newValue){
      console.log("🚀 ~ file: GroupItemContent.vue:99 ~ activeGroupIndex ~ newValue:", activeGroupIndex)
    }
  },
};
</script>
<style scoped>
@import url("https://fonts.googleapis.com/css?family=Inter");
.group_item_content_item {
  /* Auto layout */
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  padding: 0px;
  isolation: isolate;
  cursor: pointer;
  width: 1055px;
  min-height: 100px;
  /* Blue / 01 */
  background: #f5faff;
  /* Blue / 07 */
  border: 2px solid #2e90fa;
  /* s1 vnform */
  box-shadow: 0px 2px 60px rgba(0, 55, 95, 0.07);
  border-radius: 8px;
  /* Inside auto layout */
  flex: none;
  order: 0;
  align-self: stretch;
  flex-grow: 0;
}
.header_group_content {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
  padding: 12px 24px;
  gap: 8px;
  width: 1055px;
  height: 68px;
  background: #2e90fa;
  border-radius: 8px 8px 0px 0px;
}
.item_content_header_title {
  width: 46px;
  height: 22px;
  clear: both;
  display: inline-block;
  white-space: nowrap;
  font-weight: bold;
  font-family: "Inter";
  font-style: normal;
  font-weight: 600;
  font-size: 16px;
  line-height: 22px;
  color: white;
}
.item_content_header_function {
  display: flex;
  flex-direction: row;
  align-items: flex-start;
  padding: 0px;
  gap: 8px;
  height: 44px;
}
</style>